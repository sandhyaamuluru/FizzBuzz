using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int index;
                Console.Write("Enter Index of the Array:");// gets the input to define no of elements in an array

                index = Convert.ToInt32(Console.ReadLine());// reads index input

                object[] collection = new object[index];// array initialization to hold different data types

                Console.WriteLine("Enter Values of Array:");

                for (int i = 0; i < index; i++)
                {
                    collection[i] = Console.ReadLine();// reads array values, press ENTER after each value to input next value.
                }

                Console.WriteLine("Enter Lower Number:");

                int lowerNumber = Convert.ToInt32(Console.ReadLine()); // Reads Lower value.

                Console.WriteLine("Enter Higher Number:");

                int highNumber = Convert.ToInt32(Console.ReadLine()); // Reads higher value

                foreach (var item in collection)
                {
                    int itemvalue = 0;

                    if (Int32.TryParse((string)item, out itemvalue)) // finds if an array value is integer. if the value is integer then executes the condition.
                    {
                        if (itemvalue % lowerNumber == 0) // checks if the value is divided by lower value
                        {
                            if (itemvalue % highNumber == 0) // checks if the value is divided by higher value
                            {
                                Console.WriteLine("FizBuzz");// executes this condition if the value is divided by both lower and higher value.
                            }
                            else
                            {
                                Console.WriteLine("Fizz");// executes if the vlaue is divided by only lower value
                            }
                        }
                        else if (itemvalue % highNumber == 0)// checks if the value is executed by higher value
                        {
                            Console.WriteLine("Buzz");
                        }
                        else // executes this condition if the value is not divided by both lower and upper numbers
                        {
                            Console.WriteLine("Divided {0} by {1}", itemvalue, lowerNumber);
                            Console.WriteLine("Divided {0} by {1}", itemvalue, highNumber);
                        }
                    }
                    else //execute this condition if the value is not an integer. 
                    {
                        Console.WriteLine("Invalid Item");
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            Console.ReadLine();
        }
    }

}