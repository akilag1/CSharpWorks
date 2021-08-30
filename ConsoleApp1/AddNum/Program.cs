using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Number: ");
            string num1=Console.ReadLine();
            Console.Write("Enter the Second Number: ");
            string num2=Console.ReadLine();
            Console.Write("Sum of two numbers: ");
            Console.WriteLine(AddNum(Int32.Parse(num1),Int32.Parse(num2)));
            Console.Read();
        }

        public static int AddNum(int num1,int num2){
            int sum=num1+num2;
            return sum;
        }
    }
}
