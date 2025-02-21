namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main/dev branch of my project. CHeck different branches for different use-cases.");
            // usecase-2 calculating employee wage based on their presence
            Console.Write("Enter no. of hours you worked (max-8): ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int empWage;
            int emp_rate_per_hour = 30;
            if(hours > 8)
            {
                Console.WriteLine("Invalid Input.");
                empWage = 0;
            } else if(hours >= 5 && hours <= 8)
            {
                Console.WriteLine("Congratulations! Your work was appreciated.");
                empWage = hours * emp_rate_per_hour;
            } else
            {
                Console.WriteLine("Sorry! You have not worked to that extent as expected.");
                empWage = 0;
            }
            Console.WriteLine($"You total wage is: Rs {empWage}/-");
        }
    }
}
