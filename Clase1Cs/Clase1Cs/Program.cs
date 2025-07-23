internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Variables");
        // Variables
        /*Variables de tipo texto
         * string = cadena de texto
         * char = un solo caracter
         */
        string nombre = string.Empty;
        char letra = 'J';


        nombre = "Juan Perez";

        Console.WriteLine("Estoy creando una variable String " + nombre);
        Console.WriteLine("Estoy creando una variable char: " + letra);

        /*Variables de tipo numerico
         * int = entero
         * double = decimal con 16 decimales
         * float = decimal con menos precision de 7 decimales
         * decimal = decimal con mas precision 
         */

        int edad = 30;
        Console.WriteLine("Estoy creando una variable int(entero): " + edad);
        float numero1 = 1.757225252525254548478484818f;
        Console.WriteLine("Estoy creando una variable float(decimal con menos precision): " + numero1);
        double numero2 = 1.757225252525254548478484818;
        Console.WriteLine("Estoy creando una variable double(decimal con mas precision): " + numero2);
        decimal numero3 = 1.757225252525254548478484818m;
        Console.WriteLine("Estoy creando una variable decimal(decimal con mas precision): " + numero3);

    
        


    }
}