using System;

namespace testAlgZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());

            int suma = 0, test=0;

            int[] liczba = new int[n+1]; //nie musze tego pisac

            for (int i = 1; i <= n; i++)
            {
                liczba[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                if (liczba[i] != 0)
                {
                    suma = suma + liczba[i];
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if ((suma / n) < liczba[i])
                {
                    test = test + 1;
                }

                if ((suma / n) > liczba[i])
                {
                    test = test - 1;
                }
            }



            Console.WriteLine("Średnia: " + suma / n);

            if (test == 0)
            {
                Console.WriteLine("W ciągu jest tyle samo...");
            }
            else
            {
                Console.WriteLine("W ciągu nie jest tyle samo...");
            }




        }
    }
}
