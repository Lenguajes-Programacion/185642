using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp ="";
           do
            {
                int valor1 = 0; 
                int valor2 = 0; 
                int R = 0; 
                Console.WriteLine();
                Console.WriteLine("Presione el simbolo para realizar la operacion:n");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.Write("n Eliga Una Opcion: "); 
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);
                Console.WriteLine("nIngrese sus dos numerosn");
                Console.Write("Valor1: ");
                valor1 = int.Parse(Console.ReadLine());
                Console.Write("Valor2: ");
                valor2 = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case "+":
                        Console.WriteLine("El resultado de la suma es:");
                        R = valor1 + valor2;
                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                        break;
                    case "-":
                        Console.WriteLine("El resultado de la resta es:");
                        R = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                        break;
                    case "*":
                        Console.WriteLine("El resultado de la multiplicacion es:");
                        R = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                        break;
                    case "/":
                        Console.WriteLine("El resultado de la division es:");
                        R = valor1 / valor2;
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        break;
                }

                Console.Write("n¿Desea Continuar? s/n: "); 
                resp = Console.ReadLine();
            }
            while (resp == "si");
        }
        public void LeerMemoria()
        {
            String archivoDB = "../../../db.jason";
            StreamReader reader = new StreamReader(archivoDB);
                    
        }
        Console.WriteLine("Dato en memoria:");
        MemoriaData memoriaData = new MemoriaData(DataTime.Now.item["operacion"]);
        Console.WriteLine(key.ToString());
        Console.WriteLine(memoriaData.resiltado.ToString());
    }
    class MemoriaData
    {
        public DataTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData(DateTime date, string operacion, int result)

        {
            fecha = date;
            operacion = operation;
            resultado = result;
        }
    }
    public void arreglo()
    {
        string[] Colores = ["Rojo", "Blanco", "Verde"];
        //List<string> colores = ["rojo", "blanco", "verde"];
        //colores.Sort();
        Array.Sort(Colores);
        Array.ForEach(Colores, (item)=>{
            Console.WriteLine(item);
            });
        sting color = Array.Find(Colores, (item) =>{
            return item == "verde";
        });
        Console.WriteLine(color);
        Console.WriteLine("Accede tus colores y separalos con comas(,)");
        string colorUser = Console.ReadLine();
        string[] newColors = colorUser.Split(' ');
        Console.WriteLine(newColors);
    }
    public void multidimensional()
    {
        int[,,] array = new int [4,2,3];
        Console.WriteLine(array);

    }
}
