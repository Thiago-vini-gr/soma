using System;

class Program
{
    static void Main()
    {
        // Leitura dos valores inteiros
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        // Calcular a soma
        int SOMA = A + B;

        // Imprimir a soma com a formatação correta
        Console.WriteLine($"SOMA = {SOMA}");
    }
}