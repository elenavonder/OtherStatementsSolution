using System;

namespace OtherStatementsProject
{
    class Program
    {
        static void Main(string[] args)
        {
          //Continue Statement only looking at odd numbers
            for (var idx = 1; idx <= 10; idx++)
            {
                if (idx % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"{idx} is odd! ");
            }
         //Ternary Operater
            var TodayIsMonday = false; //If true will say Monday
            var DayOfTheWeek = "";
            DayOfTheWeek = (TodayIsMonday == true)//can do with or without == true
                ? "Monday" : "Not Monday";//<< this is a ternary operator
            Console.WriteLine(DayOfTheWeek);
        }
    }
}
