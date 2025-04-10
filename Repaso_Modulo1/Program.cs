namespace Repaso_Modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("Repaso bucles");
            /*
             * *
             * * *
             * * * *
             * * * * *
             */

            // For loop:
            int i, j, k, filas, espacio;
            Console.WriteLine("Ingresa el numero de filas");
            filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primer Reto\n");
            for (i = 1; i <= filas; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Se acabo el bucle");

            Console.WriteLine("Segundo Reto\n");
            /*
             * 1
             * 1 2
             * 1 2 3
             * 1 2 3 4
             */
            for (i = 1; i <= filas; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            Console.WriteLine("Se acabo el bucle");

            Console.WriteLine("Tercer Reto 3a\n");
            /*
             * -----*
             * ----* *
             * ---* * *
             * --* * * *
             * -* * * * *
             */
            for (i = 1; i <= filas; i++)
            {
                for (j = 1; j <= filas-i; j++)
                {
                    Console.Write("-");
                }

                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Se acabo el bucle");

            Console.WriteLine("Tercer Reto 3b\n");
            /*
             * -----*
             * ----* *
             * ---* * *
             * --* * * *
             * -* * * * *
             */
            espacio = filas + 3 - 1;

            for (i = 1; i <= filas; i++)
            {
                for (k = espacio; k >= 1; k--)
                {
                    Console.Write("-");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                espacio--;
            }
            Console.WriteLine("Se acabo el bucle");
        }
    }
}
