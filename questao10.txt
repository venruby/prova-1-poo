using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("Digite o valor em reais: ");
        float valorReais = float.Parse(Console.ReadLine());

        
        Console.Write("Digite a taxa de câmbio (Reais para Dólares): ");
        float taxaCambio = float.Parse(Console.ReadLine());

        float valorDolares = valorReais / taxaCambio;

       
        Console.WriteLine($"O valor em dólares é: {valorDolares}");
    }
}