using System;
//https://dotnet.microsoft.com/es-es/languages/csharp

// Comentario de una línea

/*comentario
    de varias 
    líneas
*/

/// Comentario de documentación
namespace HolaMundo // Es un contenedor lógico para organizar tipos relacionados
{
    class Program // Definición de una clase
    {
        static void Main(string[] args) //Metodo principal
        {
            int miPrimerVariable;
            const int miPrimerConstante = 10;
            
            //Tipos de datos primitivos
            int entero = 5;
            double doble = 1.0;
            float flotante = 1.0f;
            char character = 'M';
            string cadena = "Hola C#";
            bool boleano = true;

            // Imprimir en consola
            Console.WriteLine(cadena);
        }
    }

}
