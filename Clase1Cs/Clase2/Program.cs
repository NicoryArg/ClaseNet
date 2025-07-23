namespace Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operaciones aritméticas
             Los operadores aritméticos incluidos en C# son
             los típicos de suma(+), resta(-), producto(*), 
             división(/) y módulo(%).*/

            /* Operaciones relacionales
              Se han incluido los tradicionales operadores de
              igualdad(==), desigualdad(!=), “mayor que” (>), 
             “menor que” (<), “mayor o igual que” (>=) y
             “menor o igual que” (<=)*/

            /*Operaciones lógicas
            Se incluyen operadores que permiten realizar las 
            operaciones lógicas típicas: “and” (&& y &), “or” 
            (|| y |), “not” (!) y “xor” (^).*/

            /* var valor = 5;
             valor = valor + 1;
             valor +=1; // Suma 1 al valor actual

             int a = 0, b=5, c = 0, d=0;

             a = b++; // Asigna el valor de b a a, luego incrementa b en 1

             c = ++b; // Incrementa b en 1, luego asigna el valor de b a c


             var hola = "Hola";
             var mundo = "Mundo";
             var saludo = hola +" "+ mundo;

             if (c < b)
                 a = c;
             else
                 a = b;*/


            // operador condicional ternario
            //a = (c < b) ? c : b; // Si c es menor que b, asigna c a a, de lo contrario asigna b a a

            //Programa para ingresar los datos de un alumno y validar si son correctos 
            //USANDO IF ELSE

            var Nombre = string.Empty;
            var Apellido = string.Empty;
            var Edad = 0;
            var Email = string.Empty;
            char respuesta;

            Console.WriteLine("Ingrese los datos del alumno ");
            Console.Write("Nombre :");
            Nombre = Console.ReadLine();
            Console.Write("Apellido :");
            Apellido = Console.ReadLine();
            Console.Write("Edad :");
            Edad = int.Parse(Console.ReadLine());
            Console.Write("Email :");
            Email = Console.ReadLine();

            Console.WriteLine("====== Datos de el Alumno ======");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Email: " + Email);

            Console.WriteLine("=====================================");
            Console.WriteLine("Los datos ingresados son correctos; ");
            Console.Write("Respuesta S = si o N = no : ");
            respuesta = char.Parse(Console.ReadLine());

            /*if(respuesta == 'S' || respuesta == 's')
            {
                Console.WriteLine("Los datos son correctos");
            }
            else if (respuesta == 'N' || respuesta == 'n')
            {
                Console.WriteLine("Los datos son incorrectos, vuelva a ingresar los datos");
            }
            else
            {
                Console.WriteLine("Respuesta no valida, vuelva a ingresar los datos");
            }*/

            //Programa para ingresar los datos de un alumno y validar si son correctos 
            //USANDO WHILE

            while (respuesta=='N' || respuesta =='n')
             {
                 Console.Clear();
                 Console.WriteLine("Ingrese los datos del alumno ");
                 Console.Write("Nombre :");
                 Nombre = Console.ReadLine();
                 Console.Write("Apellido :");
                 Apellido = Console.ReadLine();
                 Console.Write("Edad :");
                 Edad = int.Parse(Console.ReadLine());
                 Console.Write("Email :");
                 Email = Console.ReadLine();

                ImprimirDatos(Nombre,Apellido,Edad,Email);


                 Console.WriteLine("=====================================");
                 Console.WriteLine("Los datos ingresados son correctos; ");
                 Console.Write("Respuesta S = si o N = no : ");
                 respuesta = char.Parse(Console.ReadLine());

             }

            //Programa para ingresar los datos de un alumno y validar si son correctos  
            //USANDO SWITCH

            /*switch (respuesta)
            {
                case 'S':
                case 's':
                case 'Y':
                case 'y':
                    Console.WriteLine("Los datos son correctos");
                    break;
                case 'N':
                case 'n':
                    Console.WriteLine("Los datos son incorrectos, vuelva a ingresar los datos");
                    break;
                default:
                    Console.WriteLine("Respuesta no valida, vuelva a ingresar los datos");
                    break;
            }*/

        }
        //Metodo imprimir datos del alumno
        static void ImprimirDatos(string nombre, string apellido, int edad, string email)
        {
          
            Console.WriteLine("====== Datos de el Alumno ======");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("=====================================");

        }
        
    }
}
