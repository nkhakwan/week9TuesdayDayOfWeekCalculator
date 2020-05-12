namespace DayOfTheWeekCalculator
{
  public class WeekDay
  {
    int Date {get; set;}
    int Year {get; set;}

    int Month {get; set}

    public WeekDay (int date, int year, int month)
    {
      Date = date;
      Year = year;
      Month = month;
    }


  }
}