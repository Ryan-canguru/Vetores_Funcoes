using System;

class Atividade2
{
    static void Main()
    {
        int[] numeros = new int[10];
        Random aleatorio = new Random();
        int quant = 0;

        for(int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = aleatorio.Next(1,100);
        }

        Console.WriteLine("Númros do vetor:");
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write("|" + numeros[i]);
        }   
       
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
}