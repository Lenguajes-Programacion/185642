using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica2
{
    class Program
    {
        static void Calc(string[] args)
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
        int[,,] array = new int [4,4,4];
        Console.WriteLine(array);

    }
    public void Main(String[] args)
    {
        bool salir = false;
        while(!salir)
        {
            Console.WriteLine("Arreglo sencillo");
            string[] sencillo = {"Rojo", "Blanco", "Morado"};
            Console.WriteLine("[{0}]", string.Join(", ", sencillo));
            int[,,] array = new int [5,5];
            Console.WriteLine("[{0}]", string.Join(", ", dosDimenciones));
            for(int i = 0; i < dosDimenciones.GetLenght(0); i++;
            {
                for int j = 0; j < dosDimenciones.GetLenght(1); i++;
                {
                     Console.WriteLine("{0},{1}={2}", i, j, dosDimenciones[i, j];
                }
            }
            int[,,] array = new int [5,5,5];
            for(int i = 0; i < tresDimenciones.GetLenght(0); i++;
            {
                for int j = 0; j < tresDimenciones.GetLenght(1); j++;
                {
                     for int k = 0; k < tresDimenciones.GetLenght(2); i++;
                    {
                        Console.WriteLine("{0},{1},{2}={3}", i, j, K, tresDimenciones[i,j,k];
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", tresDimenciones));
            string exit = Console.ReadLine();
            int[,,] array = new int [5,5,5];
            for(int i = 0; i < cuatroDimenciones.GetLenght(0); i++;
            {
                for int j = 0; j < cuatroDimenciones.GetLenght(1); j++;
                {
                     for int k = 0; k < cuatrDimenciones.GetLenght(2); k++;
                    {
                        for int l = 0; l < cuatroDimenciones.GetLenght(3); l++;
                        {
                            Console.WriteLine("{0},{1},{2}={3}", i, j, k, l cuatroDimenciones[i,j,k, l];

                        }
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", tresDimenciones));
            string exit = Console.ReadLine();
        }
    }
}
