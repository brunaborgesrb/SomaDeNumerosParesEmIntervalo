using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário os limites inferiores e superiores
        int limiteInferior = int.Parse(Console.ReadLine());

        int limiteSuperior = int.Parse(Console.ReadLine());

        // Variável para acumular a soma dos números pares
        int somaPares = 0;

        // Loop para percorrer os números no intervalo
        for (int i = limiteInferior; i <= limiteSuperior; i++)
        {
            // Verifica se o número é par
            if (i % 2 == 0)
            {
                // Soma o número à variável somaPares
                somaPares += i;
            }
        }

        // Exibe o resultado
        Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}