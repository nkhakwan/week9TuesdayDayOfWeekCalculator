namespace DayOfTheWeekCalculator
{
  public class WeekDay : IDayCalculator
  {
    int Date {get; set;}
    int Year {get; set;}

    int Month {get; set;}

    public WeekDay (int date,  int month, int year)
    {
      Date = date;
      Month = month;
      Year = year;
    }

    

    //string FirstDayOfTheYearCalculator()
   // {
    //}
    public int NumberOfDays()
    {
      int[] Months = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
      int TotalDays = 0;
      if (Month <2 && (Year%4) != 0)
      {
        for (int i = 0; i<Month; i++)
        {
          TotalDays += Months[i];
        } 
      }
      else 
      {
        for (int i = 0; i<Month; i++)
        {
          TotalDays += Months[i];
        } 
        TotalDays = TotalDays +1;
      }
      TotalDays = TotalDays + Date;
      return TotalDays;
    }

    //string DayFinder()
    //{
    //}


  }
}