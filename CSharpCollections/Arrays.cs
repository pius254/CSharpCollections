using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCollections
{
    public class Arrays
    {
        public void CArrays()
        {
           //Initialize the array with static elements
           string[] daysOfWeek =
           {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            
            //string tuesday = daysOfWeek[].Length;

            //Loop through the array and display all the items
            foreach (var item in daysOfWeek)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
