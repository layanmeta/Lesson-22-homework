using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp first = new Camp(10, 345, 543, 500, 300, 40);
            Camp second = new Camp(30, 500, 300, 600, 400, 30);

            if (first > second)
            {
                Console.WriteLine("first camp is bigger!");

            }
            Console.WriteLine("second camp is bigger!");
                

        }
    }
}
