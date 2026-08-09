using System;

class Atividade4
{

    static void gerador(int[] gerador)
    {
        Random aleatorios = new Random();

        for(int i = 0; i<gerador.Length; i++)
            gerador[i] = aleatorios.Next(-100,100); 
    }
    static void Menor(int[] numeros,int menor)
    {      
         for(int i = 0; i< numeros.Length; i++)
            {
                if(numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            } 

        Console.WriteLine("O menor valor do vetor é: " + menor);
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
      gerador(numeros);

      int menor = numeros[0];
      Menor(numeros,menor);

      Vetor(numeros);
      
    }
}