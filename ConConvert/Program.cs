using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConConvert
{
    internal class Program
    {
        static void Main(string[] args)
            {
                // Example using TryParse to convert a string to an integer
                Console.WriteLine("Using TryParse to convert a string to an integer:");
                Console.Write("Enter an integer: ");
                string intStr = Console.ReadLine();
                if (int.TryParse(intStr, out int intResult))
                {
                    Console.WriteLine("Successfully converted: " + intResult);
                }
                else
                {
                    Console.WriteLine("Conversion failed. Invalid input.");
                }

                // Example using Convert to convert a string to a double
                Console.WriteLine("\nUsing Convert to convert a string to a double:");
                Console.Write("Enter a double: ");
                string doubleStr = Console.ReadLine();
                try
                {
                    double doubleResult = Convert.ToDouble(doubleStr);
                    Console.WriteLine("Successfully converted: " + doubleResult);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Conversion failed due to FormatException. Invalid input.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Conversion failed due to OverflowException. Input is out of range.");
                }

                // Example using Parse to convert a string to a decimal
                Console.WriteLine("\nUsing Parse to convert a string to a decimal:");
                Console.Write("Enter a decimal: ");
                string decimalStr = Console.ReadLine();
                try
                {
                    decimal decimalResult = decimal.Parse(decimalStr);
                    Console.WriteLine("Successfully converted: " + decimalResult);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Conversion failed due to FormatException. Invalid input.");
                }

                Console.ReadKey();
            }
        }

    }


