namespace Estructuras_Repetitivas
{
    static class Program
    {
        static void Main()
        {
            ////////// EJERCICIO 01 //////////
            Console.WriteLine("=== EJERCICIO 01 ===");
            // Entrada de datos
            const string nombre = "Xavier Mérida";
            const int carne = 1166726;
            int indice = 1;

            // Salida de datos
            Console.WriteLine($"Nombre: {nombre}, carne: {carne}");
            while (indice <= 20)
            {
                if (indice % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(indice);
                indice++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Read();

            ////////// EJERCICIO 02 //////////
            Console.WriteLine("\n\n=== EJERCICIO 02 ===");
            // Entrada de datos
            int numero,
                residuo;
            indice = 0;
            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Salida de datos
            indice = numero - 1;
            Console.Write(indice + 1);
            do
            {
                residuo = numero % indice;
                if (residuo == 0)
                {
                    Console.Write($", {indice}");
                }
                indice--;
            } while (indice > 0);
            Console.ReadLine();


            ////////// EJERCICIO 03 //////////
            Console.WriteLine("\n\n=== EJERCICIO 03 ===");
            // Entrada de datos
            int actual = 0;
                numero = 0;
                indice = 0;
            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Salida de datos
            Console.Write(0);
            for (indice = 1; indice < numero; indice++)
            {
                actual += indice;
                Console.Write($", {actual}");
            }
            Console.ReadLine();

            ////////// EJERCICIO 04 //////////
            Console.WriteLine("\n\n=== EJERCICIO 04 ===");
            for (int tabla = 1; tabla <= 12; tabla++)
            {
                Console.WriteLine($"\nTabla del {tabla}");
                for (indice = 0; indice <= 10; indice++)
                {
                    Console.WriteLine($"{tabla} * {indice} = {tabla * indice}");
                }
            }
        }
    }
}
