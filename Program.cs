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
            bool Result = Calculator<int>.Com(1,1);
            if(Result)
            {
                Console.WriteLine("Value Match");
            }
            else { 
                Console.WriteLine("Value not matched");
            }
            Console.ReadLine();
        }
    }

    public class Calculator<T>
    {
        public static bool Com(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
