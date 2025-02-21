namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main/dev branch of my project. CHeck different branches for different use-cases.");
            // usecase-3 adding part time employee wage
            Console.Write("Enter the number of hours you worked (4 or 8 only): ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int empWage = 0;
            int emp_rate_per_hour = 20;
            // Part-time work
            if (hours == 4) 
            {
                Console.WriteLine("You did Part-Time Work.");
                empWage = hours * emp_rate_per_hour;
            }
            // Full-time work
            else if (hours == 8) 
            {
                Console.WriteLine("Congratulations! You completed your full day's work.");
                empWage = hours * emp_rate_per_hour;
            }
            else if (hours > 0 && hours < 8)
            {
                Console.WriteLine("Invalid Input. Only 4 hours (part-time) and 8 hours (full-time) are allowed.");
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a valid number of hours.");
            }
            Console.WriteLine($"Your wage is: Rs {empWage}/-");

        }
    }
}
