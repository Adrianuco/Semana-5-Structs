/*Adriano Almanza y Juan Castellon
 * 20/09/24
 * Ejercicios 2, 3 y 6
 * Programa que lleva control de Productos y su Stock
 */

namespace ProductosApp
{
    //Se declara el Struct Producto
    public struct Producto
    {
        //Se declaran las variables/atricutos de cada producto
        public int IdProd;
        public string Nombre;
        public int Precio;
        public int CantidadEnStock;

        //Constructor para la inicializacion de los productos
        public Producto(int id, string nombre, int precio)
        {
            IdProd = id;
            Nombre = nombre;
            Precio = precio;
        }
         
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constante para el numero maximo de productos
            const int NUM_PRO = 8;

            //Se declara el array de estructura de 8 elementos
            Producto[] productos = new Producto[NUM_PRO];

            //Se inicializan los productos con valores de ejemplo
            productos[0] = new Producto(222, "iPhone", 499);
            productos[1] = new Producto(123, "Laptop", 699);
            productos[2] = new Producto(923, "Nintendo Switch", 299);
            productos[3] = new Producto(456, "Audifonos", 69);
            productos[4] = new Producto(724, "Keyboard", 49);
            productos[5] = new Producto(612, "Macbook", 999);
            productos[6] = new Producto(582, "Monitor", 199);
            productos[7] = new Producto(461, "Mouse", 29);

            //Se imprimen los datos de cada producto
            Console.WriteLine("---PRODUCTOS---");
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("ID: " + productos[i].IdProd);
                Console.WriteLine("Nombre: " + productos[i].Nombre);
                Console.WriteLine("Precio: $" + productos[i].Precio);
                Console.WriteLine();

                //Se le solicita al usuario que ingrese el stock de cada producto
                Console.Write("Ingrese el Stock: ");
                productos[i].CantidadEnStock = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para ver el precio total....");
            Console.ReadKey();
            Console.Clear();

            //Se declara una variable que llevara el precio total de los productos (sin contar stock)
            int precio = 0;
            for(int i =  0; i < productos.Length;i++)
            {
                precio += productos[i].Precio;
            }

            //Se imprime el precio total
            Console.WriteLine("---PRECIO TOTAL---");
            Console.WriteLine();
            Console.WriteLine("------->  $" + precio);
            
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para ver Disponibilidad de los Productos.....");
            Console.ReadKey();
            Console.Clear();

            //Este array guardara los productos que estan bajos en stock
            int[] falseExist = new int[NUM_PRO];


            for (int i = 0; i < productos.Length; i++)
            {
                //En caso de que el producto este bajo en stock
                //Se guardara el indice del producto dentro del array falseExist
                if (productos[i].CantidadEnStock <= 10)
                {
                    falseExist[i] = i;
                }

            }
            //Se imprimen los productos bajos en stock
            Console.WriteLine("---PRODUCTOS BAJOS EN STOCK---");
            for (int i = 0; i < falseExist.Length; i++)
            {
                //Se evalua si el indice es mayor a 0
                //Para que no haya problema con los valores no inicializados
                if (falseExist[i] > 0)
                {
                    //Se ocupa falseExist como indice para el array de productos
                    Console.WriteLine("Producto: " + productos[falseExist[i]].Nombre);
                    Console.WriteLine("Stock: " + productos[falseExist[i]].CantidadEnStock);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
