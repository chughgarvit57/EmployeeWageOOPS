namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usecase-7 refractoring the code to calculate employee wage using class methods
            Employee emp = new Employee(20,22,160);
            emp.CalculateWage();
        }
    }
}

public class Employee
{
    private int empRatePerHour;
    private int noOfWorkingDaysInMonth;
    private int maxHrsInMonth;
    public Employee(int empRatePerHour, int noOfWorkingDaysInMonth, int maxHrsInMonth)
    {
        this.empRatePerHour = empRatePerHour;
        this.noOfWorkingDaysInMonth = noOfWorkingDaysInMonth;
        this.maxHrsInMonth = maxHrsInMonth;
    }
    public void CalculateWage()
    {
        int totalWage = 0;
        int totalHoursWorked = 0;
        int totalDaysWorked = 0;
        while(totalHoursWorked < maxHrsInMonth && totalDaysWorked < noOfWorkingDaysInMonth)
        {
            Console.Write("Enter hours worked for the day: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            // Input validation
            if(hours < 0 || hours > 8)
            {
                Console.WriteLine("Invalid Input.Hours should be between 0 and 8.");
                continue;
            }
            // calculate dailywage
            int dailyWage = hours * empRatePerHour;
            totalWage += dailyWage;
            totalHoursWorked += hours;
            totalDaysWorked++;
            Console.WriteLine($"Day {totalDaysWorked}: Worked {hours} hours, Earned: {dailyWage}, Total wage: Rs{totalWage}/-");
        }
        Console.WriteLine("\nWork Limit Reached!");
        Console.WriteLine($"Total days worked: {totalDaysWorked}, Total Hours Worked: {totalHoursWorked}, Total monthly wage: Rs{totalWage}/-");
    }
}
