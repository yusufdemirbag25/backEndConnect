using backEndConnect.context;
using backEndConnect.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backEndConnect.controller
{
    internal class EmployeesController
    {
        IEmployeesService employeesService;

        public EmployeesController ()
        {
            employeesService = new EmployeesService(new DbConnect());
        }


        public void saveEmployees (int id,string name, string lastName)
        {
            employeesService.saveEmployees(id, name, lastName);
        }

        public bool update (int id,string name, string lastName)
        {
           return employeesService.update(id, name, lastName);
        }
    }
}
