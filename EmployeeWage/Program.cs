namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, This is the dev branch of my project. Please check different branches for different usecases.");
            // Use case 1 - Check whether employee is present or not
            Console.Write("Enter no. of hours you worked today (max-8) : ");
            int hours = Convert.ToInt32(Console.ReadLine());
            if(hours > 8)
            {
                Console.WriteLine("Invalid Input.");
            } else if(hours >= 6 && hours <= 8)
            {
                Console.WriteLine("Employee is present.");
            } else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
