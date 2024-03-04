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
            bool Result = Calculator.Com<string>("AS","AS");
            if(Result)
            {
                Console.WriteLine("Vale Match");
            }
            else { 
                Console.WriteLine("Value not matched");
            }
            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public static bool Com<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
