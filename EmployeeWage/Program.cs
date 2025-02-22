using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usecase-6: calculating wages till number of working days
            // or total working hours per month is achieved
            int empRatePerHour = 20;
            int maxWorkingHoursInMonth = 160; // 40(per week) * 4(weeks)
            int noOfWorkingDays = 22;
            int totalWage = 0;
            int totalHoursWorked = 0;
            int totalDaysWorked = 0;
            while(totalHoursWorked < maxWorkingHoursInMonth && totalDaysWorked < noOfWorkingDays)
            {
                Console.Write("Enter the hours worked for the day(max-8): ");
                int hours = Convert.ToInt32(Console.ReadLine());

                if(hours < 0 || hours > 8)
                {
                    Console.WriteLine("Invalid input. Hours should be between 0 and 8.");
                    continue;
                }
                // Daily wage calculator
                int dailyWage = hours * empRatePerHour;
                totalWage += dailyWage;
                totalHoursWorked += hours;
                totalDaysWorked++;

                Console.WriteLine($"Day {totalDaysWorked}: Worked {hours} hours, Earned: {dailyWage}. Total wage: Rs {totalWage}/-");
            }
            Console.WriteLine("\nWork Limit Reached!");
            Console.WriteLine($"Total days worked: {totalDaysWorked}, Total hours worked: {totalHoursWorked}, Total monthly wage: Rs {totalWage}/-");
        }
    }
}
