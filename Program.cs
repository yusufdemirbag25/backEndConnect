using backEndConnect.controller;

namespace backEndConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeesController employeesController = new EmployeesController();

            bool b = employeesController.update(3,"alican","demir");

            if (b)
            {
                Console.WriteLine("güncelleme basarili");
            }
            else
            {
                Console.WriteLine("güncelleme basarisiz");

            }
        }
    }
}
