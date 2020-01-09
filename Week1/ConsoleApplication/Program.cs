using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            //Create variables and save my data
            string Name = "Marco Antonio Bustillos Quiroz" ;
            string Location = "Ecuador" ;
            // Display that data on console
            Console.WriteLine( "My Name is: " + Name ) ;
            Console.WriteLine( "I am from: " + Location ) ;
            //Get the Current Date without Time
            DateTime thisDate = DateTime.Today;
            //Display on screen with the format
            Console.WriteLine("The Current Date is: " + thisDate.ToString("D"));
            // Get the Day of the year of today
            int Today = DateTime.Now.DayOfYear;
            // Create a object with the Christmas Day
            DateTime Christmas = new DateTime(2020, 12, 25);
            //Save the number of the day in this current year for Christmas
            int ChristmasDay = Christmas.DayOfYear;
            //Make the rest in order to know the Days lefts until Christmas
            var Rest = ChristmasDay - Today;
            //Display on Screen the total result
            Console.WriteLine("Days left until Christmas: " + Rest);
            //Example 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please insert the Total Width of the Wood:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please insert the Total Height of the Wood:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
