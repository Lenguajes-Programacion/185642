using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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
        class Memoria
        {
            public List<MemoriaData> db = new List<MemoriaData>();
            public Memoria()
            {
                db = new List<MemoriaData>();
            }
            public void LeerMemoria()
            {
                ConsoleColor currentColor = Console.BackgroundColor;
                string archivoDB = "../../../db.json";
                StreamReader reader = new StreamReader(archivoDB);
                var dbJSON = reader.ReadToEnd();
                var dbObject = JObject.Parse(dbJSON);
                foreach (var item  in dbObject)
                {
                    MemoriaData memoriaData = new MemoriaData(item.Key.ToString(), item.Value["operacion"].ToString(),item.Value["resultado"].ToString());
                    this.db.Add(memoriaData);
                    Console.WriteLine("Dato en memoria: ({0})", i);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                    memoriaData.fecha.ToLongTimeString());
                    Console.ResetColor();
                    Console.WriteLine("Operación: {0}",memoriaData.operacion);
                    Console.WriteLine("Resultado: {0}",memoriaData.resultado.ToString());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("----------------- \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    i++;
                }
            }
            public int GetMemoriaData(String key)
            {
                int index = int.Parse(key);
                MemoriaData data = db[index];
                return data.resultado;
            }
            public void GuardarMemoria(MemoriaData data)
            {
                db.Add(data);
                int i = 0;
                db.ForEach((MemoriaData memoriaData) =>
                {
                    Console.WriteLine("Dato en memoria: ({0})", i);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                    memoriaData.fecha.ToLongTimeString());
                    Console.ResetColor();
                    Console.WriteLine("Operación: {0}", memoriaData.operacion);
                    Console.WriteLine("Resultado: {0}", memoriaData.resultado.ToString());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("----------------- \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    i++;
                });
                string json = JsonConvert.SerializeObject(db.ToArray(), Formatting.Indented);
                string archivoDB = "../../../db.json";
                File.WriteAllText(archivoDB, json);
            }
            public void arreglo()
            {
                string[] Colores = { "Rojo", "Blanco", "Morado" };
                //List<string> colores = ["Rojo", "Blanco", "Morado"];
                //colores.Sort();
                Array.Reverse(Colores);
                Array.ForEach(Colores, (item)=>{
                    Console.WriteLine(item);
                });
                String color = Array.Find(Colores, (item) => {
                    return item.Length > 4;
                });
                Console.WriteLine(color);
                Console.WriteLine("Accede tus colores y separalos con comas(,):");
                String colorUser = Console.ReadLine();
                string[] newColors = colorUser.Split(' ');
                Console.WriteLine(newColors);
            }
            static void Main(String[] args)
            {
                bool salir = false;
                while (!salir)
                {
                    Console.WriteLine("Arreglo Sencillo");
                    string[] sencillo = { "Rojo", "Blanco", "Morado" };
                    Console.WriteLine("[{0}]", string.Join(", ", sencillo));
                    Console.WriteLine("Arreglo Dos Dimensiones");
                    int[,] dosDimensiones = new int[5, 5];
                
                    for (int i = 0; i < dosDimensiones.GetLength(0); i++)
                    {
                        for (int j = 0; j < dosDimensiones.GetLength(1);j++)
                        {
                            dosDimensiones[i, j] = i+j;
                            Console.WriteLine("{0},{1}={2}", i,j,dosDimensiones[i,j]);
                        }
                    }
                    Console.WriteLine("Arreglo Tres Dimensiones");
                    int[,,] tresDimensiones = new int[5, 5, 5];
                    for (int i = 0; i < tresDimensiones.GetLength(0); i++)
                    {
                        for (int j = 0; j < tresDimensiones.GetLength(1); j++)
                        {
                            for (int k = 0; k < tresDimensiones.GetLength(2); k++)
                            {
                                tresDimensiones[i, j, k] = i + j + k;
                                Console.WriteLine("{0},{1},{2}={3}", i, j,k, tresDimensiones[i, j,k]);
                            }
                        }
                    }
                    Console.WriteLine("Arreglo 4 Dimensiones");
                    int[,,,] cuatroDimensiones = new int[5, 5, 5,5];
                    for (int i = 0; i < cuatroDimensiones.GetLength(0); i++)
                    {
                        for (int j = 0; j < cuatroDimensiones.GetLength(1); j++)
                        {
                            for (int k = 0; k < cuatroDimensiones.GetLength(2); k++)
                            {
                                for (int l = 0; l < cuatroDimensiones.GetLength(3); l++)
                                {
                                    cuatroDimensiones[i, j, k,l] = i + j + k+l;
                                    Console.WriteLine("{0},{1},{2},{3}={4}", i, j, k,l, cuatroDimensiones[i, j, k,l]);
                                }
                            }
                        }
                    }
                    string exit = Console.ReadLine();
                    if(exit == "y")
                    {
                        salir = true;
                    }
                }
            }
        }
    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData( String date, String operation, String result)
        {
            fecha = DateTime.Parse(date);
            operacion = operation;
            resultado = int.Parse(result);
        }
    }
}
}
