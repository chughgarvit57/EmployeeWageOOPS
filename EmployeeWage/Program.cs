namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usecase-4 calculating employee wage using switch-case statements
            Console.Write("Enter no. of hours(4 or 8 only): ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int empWage = 0;
            int emp_rate_per_hour = 20;
            switch (hours)
            {
                case 4:
                    Console.WriteLine("You did part-time work.");
                    empWage = hours * emp_rate_per_hour;
                    break;
                case 8:
                    Console.WriteLine("Congratulations! You completed your full day's work.");
                    empWage = hours * emp_rate_per_hour;
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
            Console.WriteLine($"Your total wage is Rs {empWage}/-");
        }
    }
}
