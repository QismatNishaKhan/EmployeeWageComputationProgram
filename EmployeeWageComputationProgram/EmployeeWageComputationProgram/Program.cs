namespace EmployeeWageComputationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRoll employeeRoll = new EmployeeRoll();
            employeeRoll.WorkingHours();
            employeeRoll.CalculateEmpWge();
        }
    }
}