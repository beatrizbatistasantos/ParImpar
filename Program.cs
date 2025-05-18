Console.Clear(); 

int numero = 0;

Console.WriteLine("Digite um número:");

bool numeroEhPar = numero % 2 == 0;

//bool numeroEhPar = int.TryParse(Console.ReadLine(), out numero);
//numero = Convert.ToInt32(Console.ReadLine()!);

if (numeroEhPar)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}

