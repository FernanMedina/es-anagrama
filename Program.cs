using System;
/* Enunciado: Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Bool) 
según sean o no anagramas.
 * Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
 * NO hace falta comprobar que ambas palabras existan.
 * Dos palabras exactamente iguales no son anagrama. */
namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1;
            string palabra2;

            Console.WriteLine("Ingrese la primera palabra a comparar");
            palabra1=Console.ReadLine();
            Console.WriteLine("Ingrese la segunda palabra a comparar");
            palabra2=Console.ReadLine();

            if(esAnagrama(palabra1, palabra2))
                Console.WriteLine("Las palabras son anagramas");
            else
                Console.WriteLine("Las palabras NO son anagramas");
            Console.WriteLine("Finalizo Ejecucion");
        }

        static bool esAnagrama(string palabra1, string palabra2)
        {
            //Declaramos los arrays de tipo char
            char[] vector1;
            char[] vector2; 

            //Primero comprobamos que sean de la misma longitud
            if(palabra1.Length == palabra2.Length){
                vector1 = palabra1.ToCharArray(); //Convertimos a vector de char
                vector2 = palabra2.ToCharArray();

                Array.Sort(vector1);  //ordenamos los vectores
                Array.Sort(vector2);

                palabra1 = string.Join("",vector1); //convertimos a string nuevamente
                palabra2 = string.Join("",vector2);
            }

            if (palabra1 == palabra2)
               return true;
            else
               return false;
        }
    }
}
