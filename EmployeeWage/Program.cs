namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your company: ");
            string company = Console.ReadLine();
            Console.Write("Enter number of working days: ");
            int workingDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter max hours in a month: ");
            int maxHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee rate per hour: ");
            int empRate = Convert.ToInt32(Console.ReadLine());
            Employee employee = new Employee(company, workingDays, maxHours, empRate);
            int totalWage = employee.CalculateWage();
            Console.WriteLine($"\nTotal wage for {company}: Rs{totalWage}/-");
        }
    }
}

class Employee
{
    private string company;
    private int noOfWorkingDays;
    private int maxHoursInMonth;
    private int empRatePerHour;

    public Employee(string company, int workingDays, int maxHours, int empRate)
    {
        this.company = company;
        this.noOfWorkingDays = workingDays;
        this.maxHoursInMonth = maxHours;
        this.empRatePerHour = empRate;
    }

    public int CalculateWage()
    {
        int totalHoursWorked = 0;
        int totalWage = 0;
        int totalDaysWorked = 0;

        Console.WriteLine($"\nCalculating wage for {company}\n");

        while (totalHoursWorked < maxHoursInMonth && totalDaysWorked < noOfWorkingDays)
        {
            Console.Write("Enter no. of hours you worked on the day: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            if (hours < 0 || hours > 8)
            {
                Console.WriteLine("Invalid Input. Hours should be between 0 and 8.");
                continue;
            }

            // Calculate daily wage
            int dailyWage = hours * empRatePerHour;
            totalWage += dailyWage;
            totalHoursWorked += hours;
            totalDaysWorked++;

            Console.WriteLine($"Day {totalDaysWorked}: Worked {hours} hours, Earned Rs{dailyWage}/-, Total Wage: Rs{totalWage}/-");
        }

        Console.WriteLine($"\nWork limit reached for {company}!");
        Console.WriteLine($"Total days worked: {totalDaysWorked}, Total hours worked: {totalHoursWorked}, Total wage: Rs{totalWage}/-");

        return totalWage;
    }
}
