using System;

class chamba
{
    static void Main()
    {

        Console.WriteLine("Hola, escribe un numero y te dire si es par o impar");
        int numero = int.Parse(Console.ReadLine());


        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }

    }
}
