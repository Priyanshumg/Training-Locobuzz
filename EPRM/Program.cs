using System;
namespace UseCase_EWM
{
    class Program
    {
        static void Main(string[] args)
        {
            int WagePerHour = 20;
            int FullDayHour = 8;
            int PartTime = 4;
            int part_time_day = PartTime * WagePerHour;
            int full_time_day = WagePerHour * FullDayHour;
            int PartTimeWagePerMonth = part_time_day * 20;
            int FullTimeWagePerMonth = full_time_day * 20;


            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            Random random_obj = new Random();
            int EMP = random_obj.Next(0, 2);         
            if (EMP == 1)
            {
                Console.WriteLine("Present");
            }

            else
            {
                Console.WriteLine("Absent");
            }

        }
    }
}
