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
