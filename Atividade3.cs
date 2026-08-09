using System;
using System.Collections.Specialized;


class Atividade3
{

    static void gerador(int[] gerador)
    {
        Random aleatorios = new Random();

        for(int i = 0; i<gerador.Length; i++)
            gerador[i] = aleatorios.Next(-100,100); 
    }
    static void Maior(int[] numeros,int maior)
    {      
         for(int i = 0; i< numeros.Length; i++)
            {
                if(numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            } 

        Console.WriteLine("O maior valor do vetor é: " + maior);
    }
    static void Vetor(int[] valores)
    {
        Console.WriteLine("O números do vetor são: ");

        for(int i = 0; i< valores.Length; i++)
            {
                Console.Write("|" + valores[i]);
            }
        Console.Write("|");
    }
    static void Main()
    {
      int[] numeros = new int[10];
      int maior = numeros[0];
      gerador(numeros);
      Maior(numeros,maior);
      Vetor(numeros);
      
    }
}