

namespace LeaveManagementSystem.Web.Services.Users
{
    public interface IUsersService
    {
        Task<List<ApplicationUser>> GetEmployees();
        Task<ApplicationUser> GetLoggedInUser();
        Task<ApplicationUser> GetUserById(string userId);
    }
}