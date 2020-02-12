using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            int v1 = 0;
            int v2 = 0;
            int R = 0;
            string respuesta = "";
            Console.WriteLine("Bienvenido a la Calculadora");
            do
            {
                Console.WriteLine("\n\nIngrese sus dos numeros");
                Console.Write("Valor1: ");
                v1 = int.Parse(Console.ReadLine());
                Console.Write("Valor2: ");
                v2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("\nOpciones");
                Console.WriteLine("\n+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.Write("Presione el simbolo de la operacion deseada: ");
                respuesta = Console.ReadLine();
                string eleccion = Convert.ToString(respuesta);
                    switch (eleccion)
                    {
                        case "+":
                            Console.WriteLine("\nEl resultado de la suma es:");
                            R = v1 + v2;
                            Console.WriteLine("{0}", R);
                            break;
                        case "-":
                            Console.WriteLine("\nEl resultado de la resta es:");
                            R = v1 - v2;
                            Console.WriteLine("{0}", R);
                            break;
                        case "*":
                            Console.WriteLine("\nEl resultado de la multiplicacion es:");
                            R = v1 * v2;
                            Console.WriteLine("{0}", R);
                            break;
                        case "/":
                            Console.WriteLine("\nEl resultado de la division es:");
                            R = v1 / v2;
                            Console.WriteLine("{0}", R);
                            break;
                    }
                    Console.Write("\n¿Desea Continuar? si/no: ");
                    respuesta = Console.ReadLine();
            }
            while (respuesta == "si");
        }
    }
}
