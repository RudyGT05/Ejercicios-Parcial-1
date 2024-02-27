int opcion, numfac;
double numra, resulra;

do
{
    Console.WriteLine("Bienvenido, Pulsa el numero de la opcion que deseas");
    Console.WriteLine("1. Calcular el factorial de un número ");
    Console.WriteLine("2. Calcular la raiz cuadrada de un número ");
    Console.WriteLine("3. Salir del programa");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el número deseado ");
            numfac = int.Parse(Console.ReadLine()); 
      
            int factorial = 1;

            for (int i = 1; i <= numfac; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("El resultado es: " + factorial);
 
            break;
        case 2: 
            Console.WriteLine("Ingrese el número deseado");
            numra = double.Parse(Console.ReadLine());
            resulra = Math.Sqrt(numra);
            Console.WriteLine("La raiz cuadrada es: " + resulra);
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;
        default: 
            Console.WriteLine("El número ingresado no esta disponible actualmente.");
            break;





    }
















} while (opcion != 3);
