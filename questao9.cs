using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        int numero;

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            soma += numero;
        }
        while (numero != 0);

        Console.WriteLine($"A soma de todos os números digitados é: {soma}");
    }
}