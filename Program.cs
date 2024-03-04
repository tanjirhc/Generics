using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Result = Calculator.Equal("AB","AB");
            if(Result)
            {
                Console.WriteLine("Vale Match");
            }
            else { 
                Console.WriteLine("Value not matche");
            }
            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public static bool Equal(string value1, string value2)
        {
            return value1 == value2;
        }
    }
}
