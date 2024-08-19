using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite três notas separadas por espaço: ");
        string[] notas = Console.ReadLine().Split(' ');

        float n1 = float.Parse(notas[0]);
        float n2 = float.Parse(notas[1]);
        float n3 = float.Parse(notas[2]);

        float media = CalcularMedia(n1, n2, n3);

        Console.WriteLine($"A média das notas é: {media}");
    }

    static float CalcularMedia(float nota1, float nota2, float nota3)
    {
        return (nota1 + nota2 + nota3) / 3;
    }
}