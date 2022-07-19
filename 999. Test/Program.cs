using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_test
{
    class Program
    {   


        static void Main(string[] args)
        {
            Console.Write("Age : ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("you are {0} years old",age);
        }
    }
}