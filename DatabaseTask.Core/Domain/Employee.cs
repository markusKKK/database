using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        public int HealthCheckID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime CheckDate { get; set; }
        public string Status { get; set; }
    }

    public class Position
    {
        public int PositionID { get; set; }
        public string Title { get; set; }
    }

    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Availability { get; set; }
    }

    public class Loan
    {
        public int LoanID { get; set; }
        public int ItemID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Industry { get; set; }
        public string Size { get; set; }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PositionID { get; set; }
        public int VacationDays { get; set; }
        public int SickLeave { get; set; }
        public string HealthStatus { get; set; }
        public string AccessRights { get; set; }
        public int CompanyID { get; set; }
    }

    public class Vacation
    {
        public int VacationID { get; set; }
        public int EmployeeID { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class SickLeave
    {
        public int SickLeaveID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }

    public class Child
    {
        public int ChildID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class Parent
    {
        public int ParentID { get; set; }
        public int ParentEmployee { get; set; }
        public int ChildID { get; set; }
        public string Relationship { get; set; }
    }

    public class AccessPermission
    {
        [Key]
        public int AccessID { get; set; }
        public int EmployeeID { get; set; }
        public string Permissions { get; set; }
    }
}