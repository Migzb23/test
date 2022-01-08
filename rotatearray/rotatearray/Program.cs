using System;

namespace rotatearray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];

            n = 3;

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");

        }
    }
}
