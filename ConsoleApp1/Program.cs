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
            int[] array1 = new int[100];
            int[] frequency = new int[100];
            int n, i, j, ctr;


            Console.Write("Give the input of number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
                frequency[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (array1[i] == array1[j])
                    {
                        ctr++;
                        frequency[j] = 0;
                    }
                }

                if (frequency[i] != 0)
                {
                    frequency[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", array1[i], frequency[i]);
                }
            }


        }
    }
}
