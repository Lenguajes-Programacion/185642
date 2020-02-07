using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            switch(args[1])
            {
                case"+":
                    Console.WriteLine("Es una suma");
                    break;
                default:
                    Console.WriteLine("Los argumentos no cuentan con un operador valido:" + args[1]);
                    break;
            }
        }
    }
}
