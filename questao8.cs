

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite três números separados por espaço: ");
        string[] numeros = Console.ReadLine().Split(' ');

        int n1 = int.Parse(numeros[0]);
        int n2 = int.Parse(numeros[1]);
        int n3 = int.Parse(numeros[2]);

        int maior, menor;

        if (n1 > n2 && n1 > n3)
        {
            maior = n1;
        }
        else if (n2 > n3)
        {
            maior = n2;
        }
        else
        {
            maior = n3;
        }

        
        if (n1 < n2 && n1 < n3)
        {
            menor = n1;
        }
        else if (n2 < n3)
        {
            menor = n2;
        }
        else
        {
            menor = n3;
        }

        Console.WriteLine($"{maior} é o maior e {menor} é o menor");
    }
}