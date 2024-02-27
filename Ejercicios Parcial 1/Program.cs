using System.Timers;

int numsecreto;
do
{
    Console.WriteLine("Ingresa numeros hasta que encuentres el numero secreto: ");
    numsecreto = int.Parse(Console.ReadLine());
    switch (numsecreto)
    {
        case >= 0 and <= 42:
            Console.WriteLine("El numero secreto es mayor a este");
            break;
        case 43:
            break;
        case >= 44 and <= 100:
            Console.WriteLine("El numero secreto es menor a este");
            break;
        default: Console.WriteLine(" Solo se permiten numeros del 1 al 100");
            break;
    }

} while (numsecreto != 43);
Console.WriteLine("¡El numero secreto es 43! ¡Buen trabajo!");
Console.WriteLine("Se cerrará el programa...");

    
















