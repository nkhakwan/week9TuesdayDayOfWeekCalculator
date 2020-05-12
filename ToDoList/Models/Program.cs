using System;
using System.Collections.Generic;


namespace DayOfTheWeekCalculator
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter Day");
      string MyDay = Console.ReadLine();
      int MyIntDay = int.Parse(MyDay);
      Console.WriteLine("Please enter month");
      string MyMonth = Console.ReadLine();
      int MyIntMonth = int.Parse(MyMonth);
      Console.WriteLine("Please enter Year");
      string MyYear = Console.ReadLine();
      int MyIntYear = int.Parse(MyYear);
      WeekDay MyWeekDay = new WeekDay (MyIntDay, MyIntMonth, MyIntYear);
      Console.WriteLine($"here are the number of days {MyWeekDay.NumberOfDays()}");



    }
  }
}