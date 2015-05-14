using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz, buzz, max, i;

            Console.WriteLine("Give me a number for Fizz");
            fizz = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Give me a number for Buzz");
            buzz = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Give me a number to count to");
            max = Convert.ToInt16(Console.ReadLine());

            for (i = 0; i <= max; i++){
                if (i % fizz == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % buzz == 0){
                    Console.WriteLine("Buzz");
                } else{
                    Console.WriteLine(i);
                }
            }

        }
    }
}
