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

            //Replace an element in the array
            daysOfWeek[4] = "FurahiDay";

            //int indexOfD = Array.IndexOf(daysOfWeek, "Tuesday");
            //Console.WriteLine(indexOfD);
            //Console.WriteLine();

            //int indexOfS = Array.BinarySearch(daysOfWeek, "Sunday");
            //Console.WriteLine("Index of Sunday is: " + indexOfS);

            //string length = daysOfWeek[].Length;

            //Loop through the array and display all the items
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day.ToString());
            }

            //Reverse the items in the array
            Array.Reverse(daysOfWeek);

            Console.WriteLine();

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day.ToString());
            }

            //Reverse back the array
            Array.Reverse(daysOfWeek);

            Console.WriteLine();

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day.ToString());
            }

            //Ask users to enter and index and display the element in that index
            Console.WriteLine("Enter an index of day to look up> ");
            int dayLookup = int.Parse(Console.ReadLine());
            Console.WriteLine("The Element at that index is: " + daysOfWeek[dayLookup]);
        }
    }
}
