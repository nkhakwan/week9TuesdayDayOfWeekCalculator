export class DayCalculate {
        constructor(year,month,date){
          this.year = year;
          this.month = month;
          this.date = date;
          //this.firstDayOfTheYear = firstDayOfTheYear;
        }
    
  

  //let numberOfDays = 0;

    
  numberOfDays ()  {
    let totalDays = 0;
    let months = [0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
      if  ((this.year%4) === 0 && (this.month >2)){
        for (var i = 0; i < this.month; i=i+1){
          totalDays += months[i];
          //console.log(totalDays);
        }
        totalDays = totalDays +1 + this.date;
      } else {
        for (var i = 0; i < this.month; i=i+1){
          totalDays += months[i];
          console.log(totalDays);
        }
        totalDays = totalDays + this.date;
        //console.log(totalDays);
      }
      console.log(totalDays);
      //numberOfDays = totalDays;
      return totalDays;
  }

  dayFinder() {
    let days = ["Sunday", "Monday", "Teusday", "Wednesday", "Thursday", "Friday", "Saturday"];
    let ourDay = this.numberOfDays()%7;
    let offSet = 0;
    let day = "";
    for (var i=0; i<days.length; i=i+1){
      if (this.firstDayOfTheYearFinder() === i){   //firstDayOfTheYearFinder
        offSet = (i-1);
      }
    }
    //console.log(ourDay);
    for (var i = 0; i<days.length; i=i+1){
      if (ourDay === i){
        day= days[(i+offSet)%7];
        return day;
        //console.log(day+"we are in the loop");
      }// end of if
    } // end of for loop
  } // end of function
  firstDayOfTheYearFinder(){
    var firstDayOf2017 = 0;
    var futureFirstDayWithoutLeap = (this.year-2017) +firstDayOf2017;
    var leapYearAddition = Math.floor((this.year - 2017)/4);
    var futureFirstDayWithLeap= futureFirstDayWithoutLeap + leapYearAddition;
    var futureFirstDayWithoutRevolvingHassel = futureFirstDayWithLeap %7;
    console.log(futureFirstDayWithLeap + " " + futureFirstDayWithoutRevolvingHassel);
    return futureFirstDayWithoutRevolvingHassel;
  }
} // end of class
