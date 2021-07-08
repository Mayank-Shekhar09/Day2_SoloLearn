using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Levels
    {
        public void Levels3()
        {
         
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }


        static int Points(int levels)
        {
            //your code goes here
            if (levels == 0)
                return 0;
            return levels + Points(levels - 1);

        }
        
    }
}
