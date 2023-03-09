using System;

namespace Polimorfismo_2
{
    internal class Program
    { 
        static void Main(string[] args) 
        { 
            Husky husky = new Husky();
            Pomeranian pomeranian = new Pomeranian();
            Viralata viralata = new Viralata();

            Console.WriteLine("Elija que perro quiere activar: ");
            Console.WriteLine("A) Husky     B) Pomeranian       C) Viralata");
            string respuesta = Console.ReadLine();

            if (respuesta == "A")
            {
                Console.WriteLine(husky.ladrar());
                Console.WriteLine(husky.dormir());
                Console.WriteLine(husky.cagar());
                Console.WriteLine(husky.mear());
                Console.WriteLine(husky.comer());
            }
            if (respuesta == "B")
            {
                Console.WriteLine(pomeranian.ladrar());
                Console.WriteLine(pomeranian.dormir());
                Console.WriteLine(pomeranian.cagar());
                Console.WriteLine(pomeranian.mear());
                Console.WriteLine(pomeranian.comer());
            }
            if (respuesta == "C")
            {
                Console.WriteLine(viralata.ladrar());
                Console.WriteLine(viralata.dormir());
                Console.WriteLine(viralata.cagar());
                Console.WriteLine(viralata.mear());
                Console.WriteLine(viralata.comer());
            }
        }
    }
}