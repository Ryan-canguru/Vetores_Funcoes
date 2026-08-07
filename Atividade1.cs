using System;

class Atividade1
{
    static void Main()
    {
        int[] numeros = new int[10];
        int soma = 0;

        Console.WriteLine("Entre com os valores do vetor:");
        for(int i = 0; i< numeros.Length; i++)
        {   
            Console.Write($"[{i}] : ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }

        for(int i = 0; i< numeros.Length; i++)
        {   
            soma+= numeros[i];
        }
        
        Console.WriteLine("A soma do vetor: " + soma);
    }
}