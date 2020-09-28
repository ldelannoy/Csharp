using System;

namespace Algorithme
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int i = 1, j;
            while (i < 100)
            {
                int[] diviseurs = { 2, 3, 5, 7 };

                while (i < 100)
                {
                    for (j = 0; j <= 3; j++)
                    {
                        if (i % diviseurs[j] == 0)
                        {
                            break;
                        }
                        if (j == 3)
                        {
                            Console.WriteLine(i + " est premier");
                        }
                    }
                    i++;
                }
            }*/
            int i, j, diviseur;
            for (i = 2; i < 100; i++)
            {

                //for (int nombre1 = 1; nombre1 < 100; nombre1++)
                //{
                j = 1;
                diviseur = 0;
                while (j <= 100)
                {
                    if (i % j == 0)
                    {
                        diviseur++;
                    }
                    j++;
                }
                if (diviseur < 3)
                {
                    Console.WriteLine(i);
                }
                
            }
            /*int nombre_diviseurs = 0;
            for(int nombre = 1; nombre < 100; nombre++)
            {
                for (int diviseur = 1; diviseur <= nombre; diviseur++)
                {
                    if (nombre % diviseur == 0)
                    {
                        nombre_diviseurs = nombre_diviseurs + 1;
                    }
                }
                if(nombre_diviseurs == 2)
                {
                    Console.WriteLine(nombre);
                }
                nombre_diviseurs = 0;
            }

            //Console.WriteLine(i);   // code...
                                    // }*/

        }
    }

}





