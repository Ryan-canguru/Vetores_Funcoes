using System;

class Atividade2
{   
    static void Gerador(int[] numeros)
    {
        Random aleatorio = new Random();
        for(int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = aleatorio.Next(1,100);
        }
    }
    static void Valores(int[] valores)
    {
        Console.WriteLine("O números do vetor são: ");

        for(int i = 0; i< valores.Length; i++)
            {
                Console.Write("|" + valores[i]);
            }
        Console.Write("|");
    }
    static void Quantidade(int[] numeros, int quant)
    {
       
        for(int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] % 2 != 0)
            {
                quant++;
            }
        }
        Console.Write("\n");

        Console.WriteLine("A quantidades de impares: " + quant);
    }
    static void Main()
    {
        int[] numeros = new int[10];
        int quant = 0;
        Gerador(numeros);
        Valores(numeros);
        Quantidade(numeros, quant);
        


    }
}