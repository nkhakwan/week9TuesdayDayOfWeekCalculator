using System;
using System.Collections.Generic;


namespace DayOfTheWeekCalculator
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter Date, month, year separated by a comma");
      string MyInput = Console.ReadLine();
      string[] MyDate = MyInput.Split(','); // List didn't work as it needs to be added.
      WeekDay MyWeekDay = new WeekDay (int.Parse(MyDate[0]), int.Parse(MyDate[1]), int.Parse(MyDate[2]));
      Console.WriteLine($"here are the number of days {MyWeekDay.NumberOfDays()}");

      List<string> myString = new List<string>();
      for (int i = 0; i<MyDate.Length; i=i+1)
      {
        myString.Add(MyDate[i]);
        Console.WriteLine($"Here is the list items{myString[i]} ");
      }
      


    }
  }
}

