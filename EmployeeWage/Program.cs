namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usecase-10 calculting wage using interface approach
            Console.Write("Enter the number of companies: ");
            int numCompanies = Convert.ToInt32(Console.ReadLine());

            Employee[] employees = new Employee[numCompanies];
            for(int i= 0; i < numCompanies; i++)
            {
                Console.Write($"\nEnter details for company {i+1}:\n");
                Console.Write("Enter company name: ");
                string company = Console.ReadLine();
                Console.Write("Enter no. of working days: ");
                int workingDays = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter max hours in a month: ");
                int maxHours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter employee rate per hour: ");
                int empRate = Convert.ToInt32(Console.ReadLine());
                employees[i] = new Employee(company,workingDays,maxHours,empRate);
            }
            Console.WriteLine("\nCalculating wages for all comapnies:\n");
            for(int i = 0; i < numCompanies; i++)
            {
                int totalWage = employees[i].CaculateWage();
                Console.WriteLine($"Total wage for {employees[i].company}: Rs{totalWage}/- ");
            }
        }
    }
}

interface IEmployeeWage
{
    int CaculateWage();
}

class Employee : IEmployeeWage
{
    public string company { get; set; }
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

    public int CaculateWage()
    {
        int totalHoursWorked = 0;
        int totalWage = 0;
        int totalDaysWorked = 0;

        Console.WriteLine($"\nCalculating wage for {company}!");

        while(totalHoursWorked < maxHoursInMonth && totalDaysWorked < noOfWorkingDays)
        {
            Console.Write("Enter no. of hours you worked on the day: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            // Input Validation
            if(hours < 0 || hours > 8)
            {
                Console.WriteLine("Invalid Input. Hours should be between 0 and 8.");
                continue;
            }
            // calculating daily wage
            int dailyWage = hours * empRatePerHour;
            totalWage += dailyWage;
            totalHoursWorked += hours;
            totalDaysWorked++;
            Console.WriteLine($"Day {totalDaysWorked}: Worked {hours} hours, Earned Rs{dailyWage}/-, Total Earned: Rs{totalWage}/-");
        }
        Console.WriteLine($"\nWork Limit Reached For {company}!");
        Console.WriteLine($"Total Days Worked: {totalDaysWorked}, Total Hours Worked: {totalHoursWorked}, Total Earned Rs{totalWage}/-");
        return totalWage;
    }
}
