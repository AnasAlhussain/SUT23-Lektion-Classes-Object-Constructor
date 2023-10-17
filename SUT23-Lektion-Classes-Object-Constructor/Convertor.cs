using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Lektion_Classes_Object_Constructor
{
    internal  static class Convertor
    {
        public  static string name;
        public static double InchesToCentmeters(string heightInInches)
        {
            double inchs = double.Parse(heightInInches);
            double centemeter = (inchs * 2.54);
            return centemeter;
        }

        public static double CentemeterToInches(string heightInCentemeter)
        {
            double centmeter = double.Parse(heightInCentemeter);
            double Inch = (centmeter / 2.54);
            return Inch;
        }

        public static void Start()
        {
            Console.WriteLine("Please Select the Convertor direction !!");
            Console.WriteLine("1. From Inches to Centemeter .");
            Console.WriteLine("2. From Centimeter  to Inchs .");

            string selection = Console.ReadLine();
            double Ce, In = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please Enter the height in inchs : ");
                    Ce = HeightConvertor.InchesToCentmeters(Console.ReadLine());
                    Console.WriteLine("Hieght in Centimeter = {0:F2}", Ce);
                    break;
                case "2":
                    Console.Write("Please Enter the height in Centimeter : ");
                    In = HeightConvertor.CentemeterToInches(Console.ReadLine());
                    Console.WriteLine("Hieght in Inchs = {0:F2}", In);
                    break;
                default:
                    Console.WriteLine("Please Select a convertor.........");
                    break;
            }
        }
    }
}
