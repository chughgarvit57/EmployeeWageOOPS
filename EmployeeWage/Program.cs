namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usecase-8 compute wages for multiple companies using class Mehods
            Employee garvit = new Employee("Reliance",22,160,20);
            Employee deep = new Employee("DMart",22,160,20);
            int relianceWages = garvit.CalculateWage();
            int dmartWages = deep.CalculateWage();
            int totalCompayWages = relianceWages + dmartWages;
            Console.WriteLine("\n========== WAGE SUMMARY ==========");
            Console.WriteLine($"Total wage for Reliance: Rs{relianceWages}/-");
            Console.WriteLine($"Total wage for DMart: Rs{dmartWages}/-");
            Console.WriteLine($"Total wage for all companies: Rs{totalCompayWages}/-\n");
        }
    }
}

class Employee
{
    private string company;
    private int noOfWorkingDays;
    private int maxHoursInMonth;
    private int empRatePerHour;
    public Employee(string company, int noOfWorkingDays, int maxHoursInMonth, int empRatePerHour)
    {
        this.company = company;
        this.noOfWorkingDays = noOfWorkingDays;
        this.maxHoursInMonth = maxHoursInMonth;
        this.empRatePerHour = empRatePerHour;
    }
    public int CalculateWage()
    {
        int totalWage = 0;
        int totalHoursWorked = 0;
        int totalDaysWorked = 0;
        Console.WriteLine($"\nCalculating wage for {company}\n");
        while(totalHoursWorked < maxHoursInMonth && totalDaysWorked < noOfWorkingDays)
        {
            Console.Write("Enter no. of hours worked for the day(max-8): ");
            int hours = Convert.ToInt32(Console.ReadLine());

            // Input Validation
            if(hours < 0 || hours > 8)
            {
                Console.WriteLine("Invalid Input. Hours should be between 0 and 8.");
                continue;
            }
            // Calculating daily wage
            int dailyWage = hours * empRatePerHour;
            totalWage += dailyWage;
            totalHoursWorked += hours;
            totalDaysWorked++;

            Console.WriteLine($"Day {totalDaysWorked}: Worked {hours} hours, Earned Rs{dailyWage}/-, Total Wage: Rs{totalWage}/-");
        }
        Console.WriteLine($"\nWork Limit Reached For {company}!");
        Console.WriteLine($"Total Days Worked: {totalDaysWorked}, Total hours worked: {totalHoursWorked}, Total monthly wage: Rs{totalWage}/-");
        return totalWage;
    }
}
