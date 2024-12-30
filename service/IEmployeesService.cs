namespace backEndConnect.service
{
    internal interface IEmployeesService
    {
        void saveEmployees(int id, string name, string lastName);
        public bool update(int id, string name, string lastName);

    }
}
