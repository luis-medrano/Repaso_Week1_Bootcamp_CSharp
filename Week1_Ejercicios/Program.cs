namespace Week1_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio N° 1 \nCalcualdora");
            Console.WriteLine("----------------");

            Console.Write("Ingresa el primer número: ");
            double Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double Numero2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("¿Qué operación deseas realizar? (+, -, *, /): ");
            string operacion = Console.ReadLine();

            double Resultado = 0;

            //if (operacion == "+")
            //{
            //    Resultado = Numero1 + Numero2;
            //    Console.WriteLine($"El resultado {Numero1} + {Numero2} es:{Resultado}");
            //}
            //else if (operacion == "-")
            //{
            //    Resultado = Numero1 - Numero2;
            //    Console.WriteLine($"El resultado {Numero1} - {Numero2} es: {Resultado}");
            //}
            //else if (operacion == "*")
            //{
            //    Resultado = Numero1 * Numero2;
            //    Console.WriteLine($"El resultado {Numero1} * {Numero2} es: {Resultado}");
            //}
            //else if (operacion == "/")
            //{
            //    if (Numero2 != 0)
            //    {
            //        Resultado = Numero1 + Numero2;
            //        Console.WriteLine($"El resultado {Numero1} / {Numero2} es: {Resultado}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error no se puede dividir entre 0");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El operador ingresado es inválido");
            //}

            switch (operacion)
            {
                case "+":
                    Resultado = Numero1 + Numero2;
                    Console.WriteLine($"El resultado {Numero1} + {Numero2} es: {Resultado}");
                    break;

                case "-":
                    Resultado = Numero1 - Numero2;
                    Console.WriteLine($"El resultado {Numero1} - {Numero2} es: {Resultado}");
                    break;

                case "*":
                    Resultado = Numero1 * Numero2;
                    Console.WriteLine($"El resultado {Numero1} * {Numero2} es: {Resultado}");
                    break;

                case "/":
                    if (Numero2 != 0)
                    {
                        Resultado = Numero1 / Numero2;
                        Console.WriteLine($"El resultado {Numero1} / {Numero2} es: {Resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error no se puede dividir entre 0");
                    }
                    break;

                default:
                    Console.WriteLine("El operador ingresado es inválido");
                    break;
            }
        }
    }
}
