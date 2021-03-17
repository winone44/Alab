using System;

namespace testAlgZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n");
            int n = int.Parse(Console.ReadLine());
            int najmniejszyd = 0, najwiekszyu = 0, d=0, u=0;
            Console.WriteLine("Podaj element");

            for (int i = 1; i <= n; i++)
            {
                int liczba = int.Parse(Console.ReadLine());
                if (liczba > 0)
                {
                    if (d == 0)
                    {
                        najmniejszyd = liczba;
                        d = d + 1;
                    }
                    else
                    {
                        if (liczba < najmniejszyd)
                        {
                            najmniejszyd = liczba;
                            d = d + 1;
                        }
                    }

                }

                if (liczba < 0)
                {
                    if (u == 0)
                    {
                        najwiekszyu = liczba;
                        u = u + 1;
                    }
                    else
                    {
                        if (liczba > najwiekszyu)
                        {
                            najwiekszyu = liczba;
                            u = u + 1;
                        }
                    }

                }
            }

            if (d != 0)
            {
                Console.WriteLine("Najmniejsza dodatnia " + najmniejszyd);
            }

            if (u != 0)
            {
                Console.WriteLine("Najwieksza ujemna " + najwiekszyu);
            }

        }
    }
}
