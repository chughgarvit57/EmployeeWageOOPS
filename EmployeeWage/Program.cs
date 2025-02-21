namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //usecase-5 calculating total wages assuming there are are 20 working days in a month
            Console.Write("Enter no. of working hours per day(1-8): ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int empWage = 0;
            int empRatePerHour = 20;
            int workingDays = 20;
            int totalWage = 0;
            switch (hours)
            {
                case 1:
                    Console.WriteLine("You worked for 1 hour today.");
                    empWage = hours * empRatePerHour;
                    break;
                case 2:
                    Console.WriteLine("You worked for 2 hours today.");
                    empWage = hours * empRatePerHour;
                    break;
                case 3:
                    Console.WriteLine("You worked for 3 hours today.");
                    empWage = hours * empRatePerHour;
                    break;
                case 4:
                    Console.WriteLine("You worked for 4 hours today.");
                    empWage = hours * empRatePerHour;
                    break;
                case 5:
                    Console.WriteLine("You worked for 5 hours today.");
                    empWage = hours * empRatePerHour;
                    break;
                case 6:
                    Console.WriteLine("You worked for 6 hours today.");
                    empWage = hours * empRatePerHour;
                    break;
                case 7:
                    Console.WriteLine("You worked for 7 hours today.");
                    empWage = hours * empRatePerHour;
                    break;
                case 8:
                    Console.WriteLine("You worked for 8 hours today.");
                    empWage = hours * empRatePerHour;
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please enter hours between 1 to 8.");
                    break;
            }
            totalWage = empWage * workingDays;
            if (totalWage > 0)
            {
                Console.WriteLine($"Your total wage for {workingDays} working days is: Rs {empWage}/-");
            }
        }
    }
}
