using System.Timers;

int num, tabla;

Console.WriteLine("Ingrese el numero  que desea y se mostrará la su respectiva tabla de multiplicar del 1 al 10");
num = int.Parse(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    tabla = num * i;
    Console.WriteLine("*"+i+" = "+tabla);

}



    
















