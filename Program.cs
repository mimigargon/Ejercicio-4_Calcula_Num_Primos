using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_Calcula_Num_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int divisor = 0; 
            int numDivisores = 0;

            for(num = 2; num <=100; num++)
            {
                for (divisor = 1; divisor <= num; divisor++)
                {

                    if(num % divisor == 0)
                    {
                        numDivisores += 1;
                    }

                }

                if(numDivisores <= 2)
                {
                    Console.WriteLine(num);
                }

                numDivisores = 0;
            }


        }
    }
}
