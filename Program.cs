/*
 DAVID WILKINS
 GRAND CIRCUS PRE WORK
 01/04/18

 THIS PROGRAM ALLOWS A USER TO ENTER TO DATES, AND THEN DISPLAYS THE DIFFERENCE BETWEEN THE
 TWO DATES IN YEARS, MONTHS, DAYS, HOURS AND MINUTES.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateChallenge
{
    class Program
    {

        public static void dates()
        {
            try
            {
                Console.Write("Enter a date using the MM/DD/YYYY format: "); //PROMPT USER FOR A DATE
                DateTime startDate = DateTime.Parse(Console.ReadLine()); //CONVERT INPUT INTO A DATETIME
                Console.Write("Enter another date using the MM/DD/YYYY format: ");
                DateTime endDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("You entered: " + startDate.ToShortDateString() + " & " + endDate.ToShortDateString());

                if (startDate < endDate) //IF THE SECOND DATE IS LATE THAN THE FIRST DATE, REVERSE THEM SO IT DOESN'T SHOW NEGATIVE #'S
                {
                    DateTime newStart = endDate;
                    DateTime newEnd = startDate;
                    startDate = newStart;
                    endDate = newEnd;
                }

                double result = (startDate - endDate).TotalDays;
                Console.WriteLine("The difference in time between those dates is: "); //DISPLAY RESULTS TO THE USER
                Console.WriteLine("Years: " + Math.Round((result / 365), 2));
                Console.WriteLine("Months: " + Math.Round((result / 30), 2));
                Console.WriteLine("Days: " + (result));
                Console.WriteLine("Hours: " + (startDate - endDate).TotalHours);
                Console.WriteLine("Minutes: " + (startDate - endDate).TotalMinutes);
                Console.WriteLine();
            }
            catch
            {   //IF THE USER ENTERS BAD DATE WHEN ASKED FOR A DATE, REPROMPT THEM FOR CORRECT INPUT
                Console.WriteLine("Entries must be in the MM/DD/YYYY format, for example January 1st 2018 is 01/01/2018.");
                dates();
            }
            //LETS USER GO THRU APP AGAIN WITHOUT HAVING TO RELOAD IT.
            Console.Write("Enter 'y' to try again or any other key to exit the program: ");
            string input = Console.ReadLine();
            input = input.ToLower();
            if (input == "y")
            {
                dates();
            }
        }

        static void Main(string[] args)
        {
            dates(); //CALL THE METHOD THAT CONTAINS THE PROCEDURES FOR CALCULATING DATE DIFFERENCES
            Console.ReadKey();
        }
    }
}
