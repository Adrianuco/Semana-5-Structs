using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRegistro9
{
    //Declaramos un "struct" fuera del "main" donde se guardarán los datos del auto
    public struct Auto
    {
        //Declaramos los 3 datos del auto dentro el "struct"
        public string Marca;
        public string Modelo;
        public int Año;

        //Usando "Acciones rápidas y refactorizaciones" generamos el constructor para convertir los datos y usarlos en el "main"
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
            //Declaramos una variable de tipo "int" que se digite la cantidad de autos a registrar
            int Num1;

            //Usamos un bucle "do-while" para crear un ciclo donde se le pregunte al usuario los autos que desea registrar
            do
            {
                //Le damos la bienvenida al usuario, le preguntamos los autos a registrar, y leemos la cantidad con la variable que ingresara el usuario
                Console.WriteLine("Bienvenido al sistema de registro de Autos!");
                Console.Write("Cuántos autos desea registrar? ");
                Num1 = int.Parse(Console.ReadLine());

                //Usamos un "if" y un "if else" para verificar la cantidad ingresada
                if (Num1 == 0)
                {
                    //Si la cantidad ingresada es 0, se le informa al usuario que decidió registrar ningún auto y se le da fin al programa
                    Console.WriteLine("");
                    Console.WriteLine("Se decidió registrar ningún auto...");
                    break;
                }
                else if (Num1 < 0)
                {
                    //Si la cantidad ingresada no es un número positivo, se le informa al usuario que ingreso una cantidad incorrecta
                    Console.WriteLine("");
                    Console.WriteLine("Se ingreso una cantidad incorrecta, intentelo otra vez...");
                    Console.WriteLine("");
                }
            }
            //Con el "while" se verifica que la cantidad ingresada no es positivo, y si no lo es, se repite la primera pregunta
            while (Num1 < 0);
            
            //Se declara y crear un "array" con el "struct" de Auto, y que tiene un tamaño definido con "Num1"
            Auto[] Autos = new Auto[Num1];

            //Usamos un ciclo "for" para poder repetir el registro de auto dependiendo de cuantos se desea registrar
            for (int i = 0; i < Num1; i++)
            {
                //Usando la variable "i", indicamos el número de auto que se esta registrando y en la cual se suma 1 conforme pase el ciclo
                Console.WriteLine("");
                Console.WriteLine("Auto {0}", i + 1);
                //Solicitamos cada dato del auto al usuario, se registran con el "struct" creado y en el "array" usando el índice de este conforme pase el ciclo
                Console.Write("Ingrese la marca del auto: ");
                Autos[i].Marca = Console.ReadLine();
                Console.Write("Ingrese el modelo del auto: ");
                Autos[i].Modelo = Console.ReadLine();
                Console.Write("Ingrese el año del auto: ");
                Autos[i].Año = int.Parse(Console.ReadLine());

                //Le informamos al usuario que se registro el auto de manera exitosa
                Console.WriteLine("Auto Registrado Exitosamente!");
            }

            //Con otro "for" imprimimos cada auto registrado dentro del "array" haciendo uso del índice de este
            for (int i = 0; i < Autos.Length; i++)
            {
                Console.WriteLine("");
                //Igualmente con la variable "i", se indica y ubica el número del auto registrado
                Console.WriteLine("Auto {0}", i + 1);
                Console.WriteLine("La marca del auto es: {0}", Autos[i].Marca);
                Console.WriteLine("El modelo del auto es: {0}", Autos[i].Modelo);
                Console.WriteLine("El año del auto es: {0}", Autos[i].Año);
            }
            Console.ReadKey();
        }
    }
}
