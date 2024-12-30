using System.ComponentModel.DataAnnotations;

namespace backEndConnect.entity
{
    internal class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
