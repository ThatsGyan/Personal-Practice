using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4netpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1st Number");
           int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;
            Console.WriteLine("Devision Result : " result);
        }
    }
}
