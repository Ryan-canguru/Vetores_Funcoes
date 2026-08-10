using System;

class Atividade1
{   
    static void Vetor(int[] vetor)
    {
        Console.WriteLine("Entre com os valores do vetor:");
        for(int i = 0; i< vetor.Length; i++)
        {   
            Console.Write($"[{i}] : ");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }
    }
    static void Soma(int[] numeros, int soma)
    {
        for(int i = 0; i< numeros.Length; i++)
        {   
            soma+= numeros[i];
        }
        
        Console.WriteLine("A soma do vetor: " + soma);
    }
    static void Valores(int[] valores)
    {
        Console.WriteLine("O números do vetor são: ");

        for(int i = 0; i< valores.Length; i++)
            {
                Console.Write("|" + valores[i]);
            }
        Console.Write("|");
        Console.Write("\n");
    }
    static void Main()
    {
        int[] numeros = new int[10];
        Vetor(numeros);        
        Valores(numeros);

        int soma = 0;
        Soma(numeros, soma);
        
    }
}