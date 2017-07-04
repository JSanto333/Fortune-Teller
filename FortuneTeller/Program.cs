using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            string lowerCaseFirstName = firstName.ToLower();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string lowerCaseLastName = lastName.ToLower();

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("How many siblings do you have?");
            int numberOfSiblings = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color?");
            string color = Console.ReadLine();
            if (color == "help")
            {
                Console.WriteLine("Theses are the ROYGBIV colors: red, orange, yellow, green, blue, indigo, violet.");
                Console.WriteLine("Please enter one of the above colors.");
                color = Console.ReadLine();
            }
            string lowerCaseColor = color.ToLower();
            string modeOfTransportation;
            switch (lowerCaseColor)
            {
                case "red":
                    modeOfTransportation = "plane";
                    break;
                case "orange":
                    modeOfTransportation = "boat";
                    break;
                case "yellow":
                    modeOfTransportation = "train";
                    break;
                case "green":
                    modeOfTransportation = "car";
                    break;
                case "blue":
                    modeOfTransportation = "bike";
                    break;
                case "indigo":
                    modeOfTransportation = "ferry";
                    break;
                case "violet":
                    modeOfTransportation = "trolley";
                    break;
                default:
                    modeOfTransportation = "I don't have any transportation";
                    break;
            }

            string retireAge;

            if (userAge % 2 == 0)
            {
                retireAge = "20";
            }
            else
            {
                retireAge = "30";
            }

            string location;
            if (numberOfSiblings == 0)
            {
                location = "Rome";
            }
            else if (numberOfSiblings == 1)
            {
                location = "Sicily";
            }
            else if (numberOfSiblings == 2)
            {
                location = "Tokyo";
            }
            else if (numberOfSiblings == 3)
            {
                location = "Paris";
            }
            else if (numberOfSiblings > 3)
                
            {
                location = "Detroit";
            }
            else
            {
                location = "a bad place";
            }

            //Determining money in the bank depending on birth month

            string amountOfMoney;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                amountOfMoney = "$100,000";
            }
            else if (birthMonth >=5 && birthMonth <=8)
            {
                amountOfMoney = "$200,000";
            }
            else if (birthMonth >=9 && birthMonth <=12)
            {
                amountOfMoney = "$300,000";
            }
            else
            {
                amountOfMoney = "$0";
            }

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retireAge + " years with " + amountOfMoney + " in the bank, a vacation home in " + location + " and a " + modeOfTransportation);
        }
    }
}