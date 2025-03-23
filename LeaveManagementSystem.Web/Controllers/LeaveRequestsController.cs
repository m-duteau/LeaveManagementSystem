using LeaveManagementSystem.Application.Models.LeaveRequests;
using LeaveManagementSystem.Application.Services.LeaveRequests;
using LeaveManagementSystem.Application.Services.LeaveTypes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagementSystem.Web.Controllers;

[Authorize]
public class LeaveRequestsController(ILeaveTypesService _leaveTypesService, ILeaveRequestsService _leaveRequestsService) : Controller
{
    // Employee View requests
    public async Task<IActionResult> Index()
    {
        var model = await _leaveRequestsService.GetEmployeeLeaveRequests();
        return View(model);
    }

    // Employee Create requests
    public async Task<IActionResult> Create(int? leaveTypeId)
    {
        var leaveTypes = await _leaveTypesService.GetAll();
        var leaveTypesList = new SelectList(leaveTypes, "Id", "Name", leaveTypeId);
        var model = new LeaveRequestCreateVM
        {
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
            LeaveTypes = leaveTypesList
        };

        return View(model);
    }

    // Employee Create requests (post)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(LeaveRequestCreateVM model)
    {
        // Validate that days don't exceed the allocation
        if (await _leaveRequestsService.RequestDatesExceedAllocation(model))
        {
            ModelState.AddModelError(string.Empty, "The number of days requested exceeds the current number of days allocated for this leave type.");
            ModelState.AddModelError(nameof(model.EndDate), "The number of days requested is invalid.");
        }
        if (ModelState.IsValid)
        {
            await _leaveRequestsService.CreateLeaveRequest(model);
            return RedirectToAction(nameof(Index));
        }
        var leaveTypes = await _leaveTypesService.GetAll();
        var leaveTypesList = new SelectList(leaveTypes, "Id", "Name");
        model.LeaveTypes = leaveTypesList;

        return View(model);
    }

    // Employee Cancel requests
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Cancel(int Id)
    {
        await _leaveRequestsService.CancelLeaveRequest(Id);
        return RedirectToAction(nameof(Index));
    }

    // Admin/Super review requests
    [Authorize(Policy = "AdminSuperOnly")]
    public async Task<IActionResult> ListRequests()
    {
        var model = await _leaveRequestsService.AdminGetAllLeaveRequests();
        return View(model);
    }

    // Admin/Super review single request per leaveRequestId
    public async Task<IActionResult> Review(int Id)
    {
        var model = await _leaveRequestsService.GetLeaveRequestForReview(Id);
        return View(model);
    }

    // Admin/Super review requests (post)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Review(int Id, bool approved)
    {
        await _leaveRequestsService.ReviewLeaveRequest(Id, approved);
        return RedirectToAction(nameof(ListRequests));
    }
}
