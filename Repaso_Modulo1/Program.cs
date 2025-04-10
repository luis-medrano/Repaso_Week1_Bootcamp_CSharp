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
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                espacio--; // Restando los espacios para que tome forma de piramide
            }
            Console.WriteLine("Se acabo el bucle");


            // Ejercicios de arreglos
            // Listar

            int[] otrosNumeros = new int[] { 10, 20, 30, 40, 50 };

            for (i = 0; i<otrosNumeros.Length; i++)
            {
                Console.WriteLine("El valor del array es " + otrosNumeros[i]);
            }

            int total2 = 0;
            for (int i1 = 0; i1 < otrosNumeros.Length; i1++)
            {
                total2 += otrosNumeros[i1];
            }

            //Obtener
            int total = 0;
            foreach (int valor in otrosNumeros)
                //total=total+valor;
                total += valor;
            Console.WriteLine(total.ToString());


            // Ejercicio
            // Contar los duplicados dentro de un arreglo
            // int[] arreglo = new int[] {44, 44, 32, 35}
            // Resultado: Hay 2 valores duplicados en el arreglo

            int[] numerosArray = new int[] { 44, 44, 32, 35, 50 };
            int[] numerosTemporal = new int[numerosArray.Length];
            total = 0;

            for (int i1 = 0; i1 < numerosArray.Length; i1++)
            {
                numerosTemporal[i1] = numerosArray[i1];
            }

            for (int i1 = 0; i1 < numerosArray.Length; i1++)
            {
                for (int j1 = 0; j1 < numerosArray.Length; j1++)
                {
                    if (numerosArray[i1] == numerosTemporal[j1])
                    {
                        total++;
                    }
                }
                if (total > 1) 
                    Console.WriteLine("El numero " + numerosArray[i1] + " tiene repetidos: " + total);
                else
                    Console.WriteLine("El numero " + numerosArray[i1] + " no tiene repetidos");
                total = 0;
            }
        }
    }
}
