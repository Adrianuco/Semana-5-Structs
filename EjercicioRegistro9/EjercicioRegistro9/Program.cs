using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRegistro9
{
    public struct Auto
    {
        public string Marca;
        public string Modelo;
        public int Año;

        public Auto(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            do
            {
                Console.WriteLine("Bienvenido al sistema de registro de Autos!");
                Console.Write("Cuantos autos desea registrar? ");
                Num1 = int.Parse(Console.ReadLine());

                if (Num1 == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se decidio registrar ningun auto...");
                    break;
                }
                else if (Num1 < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se ingreso una cantidad incorrecta, intentelo otra vez...");
                    Console.WriteLine("");
                }
            }
            while (Num1 < 0);
            
            Auto[] Autos = new Auto[Num1];

            for (int i = 0; i < Num1; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Auto {0}", i + 1);
                Console.Write("Ingrese la marca del auto: ");
                string marca = Console.ReadLine();
                Console.Write("Ingrese el modelo del auto: ");
                string modelo = Console.ReadLine();
                Console.Write("Ingrese el año del auto: ");
                int año = int.Parse(Console.ReadLine());

                Autos[i] = new Auto(marca, modelo, año);

                Console.WriteLine("Auto Registrado Exitosamente!");
            }

            for (int i = 0; i < Autos.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Auto {0}", i + 1);
                Console.WriteLine("La marca del auto es: {0}", Autos[i].Marca);
                Console.WriteLine("El modelo del auto es: {0}", Autos[i].Modelo);
                Console.WriteLine("El año del auto es: {0}", Autos[i].Año);
            }

            Console.ReadKey();
        }
    }
}
