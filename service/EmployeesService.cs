using backEndConnect.context;
using backEndConnect.entity;

namespace backEndConnect.service
{
    internal class EmployeesService : IEmployeesService
    {
        DbConnect d;

        public EmployeesService(DbConnect db)
        {
            d = db;
        }


        public void saveEmployees(int id, string name, string lastName)
        {
            Employees e = d.Employees.FirstOrDefault(x => x.EmployeeID.Equals(id));

            if (e != null)
            {
                return;
            }
            Employees employees = new Employees();
            employees.EmployeeID = id;
            employees.FirstName = name;
            employees.LastName = lastName;
            d.Employees.Add(employees);
            d.SaveChanges();
        }
        public bool update(int id, string name, string lastName)
        {
            Employees employees = d.Employees.FirstOrDefault(x => x.EmployeeID.Equals(id));

            if (employees == null)
            {
                return false;
            }
            else
            {
                employees.FirstName = name;
                employees.LastName = lastName;
                d.Employees.Update(employees);
                d.SaveChanges();
                return true;

            }

        }
    }
}
