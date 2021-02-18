namespace Entities.EmployeeReport
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeveloper { get; set; }

        public int? ManagerId { get; set; }
        public virtual Employee Manager { get; set; }
    }
}
