# Leave Management System

The Leave Management System project is a C# driven project using the ASP.NET Core framework that allows a company to allocate and keep track of different leave types and requests for its employees.
The project features both a basic Employee view and an Administrator view that adds administrative functions like adding/editing leave types or periods, as well as reviewing and accepting/denying leave requests.

# Login and Registration
<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/login-register.png?raw=true>
</p>

Users of the system will gain access to the system by registering using their first name, last name, email, date of birth, password, and selection of their role within the company.
Upon registration, an email will be sent to the user with a confirmation link. The user will not be able to access the system until this confirmation link is visited and their email has been confirmed by the system.

<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/email-confirmation.png?raw=true>
</p>

After the email is confirmed, the user may login to the system and access the Leave Allocations module,
where their available leave types will have already been populated with values that are determined based on the leave type's base value and how far into the current period they are when registering.

# Employee Leave Allocation Module
<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/employee-view-allocations.png?raw=true>
</p>

The Leave Allocation module will allow employees to monitor their available days for different leave types.
By clicking the **Request Leave** button, the employee will be able to enter dates wherein they can request leave for the respective leave type.

<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/employee-view-create-leave-request.png?raw=true>
</p>

The form for creating a leave request will also allow the user to change the leave type they would want to use in the event that they selected **Request Leave** for an unintended leave type.
Additional information is also able to be provided to attach a message to the leave request if they wish to provide more context for why leave is being requested.

<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/employee-view-leave-request-history.png?raw=true>
</p>

After creating one or more leave requests, employees may view their request history by clicking the **View Request History** button on the Leave Allocation module's initial screen.
Here, the employee may view whether requests are pending, accepted, or denied. Also, employees are able to cancel leave requests from this screen if leave is no longer needed or was requested erroneously.

# Administrator Views and Functions

To have a functioning Administrator account, consult [ApplicationUserConfiguration.cs](https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem.Data/Configurations/ApplicationUserConfiguration.cs) and modify the fields so that they are appropriate for your respective administrator.

### Periods
<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/admin-view-periods.png?raw=true>
</p>

Periods must be added in order for leave types to be appropriately allocated to employees based off of the current fiscal year. Creating or editing a period will direct to the following view:

<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/admin-view-create-period.png>
</p>

The periods displayed use the first day of the year and last day of the year to determine the period, but this can vary depending on your company's determined fiscal year.
Ensure that dates are entered correctly based on the information that is relevant to your company.

Once periods are set, leave types will be automatically allocated when a user registers or when an administrator views an employee's allocations and the system detects that there are missing allocations.
The days allocated for each leave type for an employee is based on accrual using the current date as it relates to the period's start date.
(Refer to the AllocateLeave method in [LeaveAllocationsService.cs](https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem.Application/Services/LeaveAllocations/LeaveAllocationsService.cs).)

### Leave Types
<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/admin-view-leave-types.png?raw=true>
</p>

Administrators may view, add, edit, or delete the different leave types that are made available by the system. Creating or editing leave types will direct to the following view:

<p align=center>
  <img src=https://github.com/m-duteau/LeaveManagementSystem/blob/master/LeaveManagementSystem-Screenshots/admin-view-create-leave-type.png>
</p>

After adding the leave type name and base value for number of days, it will be added to the leave types list. 
