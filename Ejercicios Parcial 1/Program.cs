using System.Timers;

int num1, num2, res;
string op;
Console.WriteLine("Ingrese el primer núemro");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el operador");
op = Console.ReadLine();
if (op == "-")
{
    res = num1   - num2;
    Console.WriteLine("El resultado es:" + res);
}
else if (op == "+")
{
    res=num1 + num2;
    
    Console.WriteLine("El resultado es:" + res);
}
else if (op == "*")
{
    res= num1 * num2;
    Console.WriteLine("El resultado es:" + res);
}
else if (op == "/")
{
    res= num1 / num2;
    Console.WriteLine("El resultado es:" + res);
}
else
{
    Console.WriteLine("Operador no disponible, se cerrara el programa...");
}




    
















