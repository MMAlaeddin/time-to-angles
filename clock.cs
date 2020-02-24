using System;
using System.Collections.Generic;

class Clock
{
  static void Main()
  {
    Console.WriteLine("Enter a time of day");
   string timeStr = Console.ReadLine();
   string[] separator = {":"};
   string[] timeArr = timeStr.Split(separator,StringSplitOptions.RemoveEmptyEntries);
   double mins = (double.Parse(timeArr[0])*60)+double.Parse(timeArr[1]);
   double degs = mins * .5;
   Console.WriteLine(degs+" degs");
  }
}