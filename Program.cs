Console.Clear(); 

int numero = 0;

Console.WriteLine("Digite um número:");
bool numeroEhPar = int.TryParse(Console.ReadLine(), out numero);
//numero = Convert.ToInt32(Console.ReadLine()!);

if (numeroEhPar && numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }

// else 
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }


