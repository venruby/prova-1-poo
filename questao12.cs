
   using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Digite o número limite para a sequência de Fibonacci: ");
        int limite = int.Parse(Console.ReadLine());

        
        if (limite <= 0)
        {
            Console.WriteLine("Por favor, digite um número maior que zero.");
            return;
        }

        
        int a = 0;
        int b = 1;

        Console.WriteLine("Sequência de Fibonacci:");

        
        while (a <= limite)
        {
            Console.WriteLine(a);
            int proximo = a + b;
            a = b;
            b = proximo;
        }
    }
}