using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class DivisibleBy3
    {

        public void DivBy3()
        {
            int number = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                    Console.Write("*");
                else
                    Console.Write(i);
            }
        }
    }
}
