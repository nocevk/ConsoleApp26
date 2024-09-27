using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                {

                    {
                        // Task2
                        double x = 1;
                        double y = 2;

                        if (x == 0 && y == 0)
                        {
                            Console.WriteLine("Точка знаходиться в початку координат.");
                        }
                        else if (x == 0)
                        {
                            Console.WriteLine("Точка знаходиться на осі Y.");
                        }
                        else if (y == 0)
                        {
                            Console.WriteLine("Точка знаходиться на осі X.");
                        }
                        else if (x > 0 && y > 0)
                        {
                            Console.WriteLine("Точка знаходиться в першій чверті.");
                        }
                        else if (x < 0 && y > 0)
                        {
                            Console.WriteLine("Точка знаходиться в другій чверті.");
                        }
                        else if (x < 0 && y < 0)
                        {
                            Console.WriteLine("Точка знаходиться в третій чверті.");
                        }
                        else if (x > 0 && y < 0)
                        {
                            Console.WriteLine("Точка знаходиться в четвертій чверті.");
                        }
                    }
                }

            }
        }
}
