using System;

namespace testAlgZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());
            int z = 0, suma=0, iloczyn = 1;
            int[] liczba = new int[n+1];

            for (int i = 1; i <= n; i++)
            {
                liczba[i] = int.Parse(Console.ReadLine());
            }



            for (int i = 1; i <= n-1; i++)
            {

                if (((liczba[i] * liczba[i+1]) < 0) && ((liczba[i] % 2 == 0) && (liczba[i+1] % 2 != 0) || (liczba[i] % 2 != 0) && (liczba[i + 1] % 2 == 0)))
                {
                    Console.WriteLine(liczba[i]);
                    Console.WriteLine(liczba[i+1]);
                    z = z + 1;
                }


            }

            for (int i = 1; i < n; i++)
            {
                if (liczba[i] > 0)
                {
                    suma = suma + liczba[i];
                }


                if (liczba[i] > 0)
                {
                    iloczyn = iloczyn * liczba[i];
                }

            }

            Console.WriteLine(z);
            Console.WriteLine("Suma elementó dodatnich" + suma);
            Console.WriteLine("Iloczyn elementów ujemnych" + iloczyn);
        }
    }
}
