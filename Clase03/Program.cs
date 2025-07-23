using System.Threading;

internal class Program
{
   
    private static void Main(string[] args)
    {
        //break

        //for (int id = 0; id <= 10; id++)
        //{
        //    Thread.Sleep(800);
        //    Console.WriteLine("ID: " + id);
        //    if (id == 5)
        //    {
        //        break;
        //    }
        //}
        //Console.ReadKey();

        //continue

        //for (int id = 0; id <= 10; id++)
        //{
        //    Thread.Sleep(800);           
        //    if (id == 8)
        //    {
        //        Console.WriteLine();
        //        continue;
        //    }
        //    Console.WriteLine("ID: " + id);
        //}
        //Console.ReadKey();

        //goto

        //    for (int id = 0; id <= 10; id++)
        //    {
        //        Thread.Sleep(800);
        //        if (id == 8)
        //        {
        //            goto liquidacion;
        //        }
        //        Console.WriteLine("ID: " + id);
        //    }

        //liquidacion:
        //    Console.WriteLine("se envio al departamaneto de liquidacion");

        //    Console.ReadKey();

        // For simple

        //Console.WriteLine("For incrementendo de a 1");
        //for (int x = 0; x <= 5; x++)
        //{
        //    Console.WriteLine(x);
        //}

        //Console.WriteLine("For decreciendo de a 1");

        //for (int x = 5; x >= 0; x--)
        //{
        //    Console.WriteLine(x);
        //}

        //char letra;

        //for (letra = 'a'; letra <= 'z'; letra++)
        //{
        //    Console.WriteLine(letra);
        //}

        //For anidados

        //for (int x = 0; x <= 5; x++)
        //{
        //    for (int y = 0; y <= 5; y++)
        //    {
        //        Console.WriteLine("Hola Digitalers - "+ y );
        //    }

        //    Console.WriteLine(x);
        //}
        //Console.ReadKey();

        // While
        //bool encender = false;

        //while (encender)
        //{
        //    Console.WriteLine("Hola Digitaler");
        //}

        // Do While

        //do
        //{
        //    Console.WriteLine("Hola Digitaler");

        //    for (int x = 0; x <= 5; x++)
        //    {
        //        Console.WriteLine(x);

        //        if (x == 3)
        //        {
        //            encender = true;
        //        }
        //    }

        //} while (encender) ;

        //Console.ReadKey();

        //Array unidimensional

        //int[] numeros;
        //numeros = new int[5];
        //numeros[0] = 5;
        //numeros[2] = 10;
        //numeros[4] = 15;

        //for (int i = 0; i < numeros.Length; i++)
        //{
        //    Console.WriteLine("El valor del indice " + i + " es: " + numeros[i]);
        //}

        //foreach (int elemento in numeros)
        //{
        //    Console.WriteLine("El valor del elemento es: " + elemento);
        //}

        //array multidimensional

        //int[,] numeros = new int[3, 3];
        ////{1,2,3}

        //for (int fila = 0; fila < 3; fila++)
        //{
        //    for (int col = 0; col < 3; col++)
        //    {
        //        Console.WriteLine($"Ingrese un valor de col {col} : ");
        //        numeros[fila, col] = Convert.ToInt32(Console.ReadLine());
        //        //int.parse(Console.ReadLine());
        //    }
        //}

        //Console.Clear();

        //for (int fila = 0; fila < 3; fila++)
        //{
        //    for (int col = 0; col < 3; col++)
        //    {
        //        Console.Write(" " + numeros[fila,col]);

        //        //int.parse(Console.ReadLine());
        //    }
        //    Console.WriteLine();

        //}

        //Listas

        List<string> nombres = new List<string>() { "Horacio", "Juan", "Maria","sofia" };

        nombres.Add("Pedro");

        nombres.Remove("Juan");

        Console.WriteLine(" nombre [2] es " + nombres[2]);


        foreach (var nombre in nombres)
        {
            Console.WriteLine("Nombre: " + nombre);
        }

    }
}