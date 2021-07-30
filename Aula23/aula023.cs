using System;

class Aula23
{

  public static void Main()
  {
    int[] vetor1 = new int[5];
    int[] vetor2 = new int[5];
    int[] vetor3 = new int[5];
    int[,] matriz = new int[2, 5] { { 11, 20, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

    Random random = new Random();

    for (int i = 0; i < vetor1.Length; i++)
    {
      vetor1[i] = random.Next(50);
    }


    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Elementos do vetor 1");
    foreach (int n in vetor1)
    {
      Console.WriteLine(n);
    }

    // public static int BinarySearch(array,valor)
    Console.WriteLine("BinarySearch");
    int procurado = 33;
    int pos = Array.BinarySearch(vetor1, procurado);
    Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");


    Console.ForegroundColor = ConsoleColor.Cyan;
    // public static void Copy(Ar_origem, Ar_destino,qtd_elementos);
    Console.WriteLine("Copy");
    Array.Copy(vetor1, vetor2, vetor1.Length);
    foreach (int n in vetor2)
    {
      Console.WriteLine(n);
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");



    Console.ForegroundColor = ConsoleColor.DarkBlue;
    //  public void CopyTo(Ar_destino, a_partir_desta_pos);
    Console.WriteLine("CopyTo");
    vetor1.CopyTo(vetor3,0);
    foreach(int n in vetor3) {
      Console.WriteLine(n);
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");




    Console.ForegroundColor = ConsoleColor.DarkCyan;
    // public get LowerBound(dimensão);
    Console.WriteLine("GetLowerBound");
    int MenorIndiceVetor=vetor1.GetLowerBound(0);
    int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
    Console.WriteLine("Menor índice do vetor1 {0}",MenorIndiceVetor);
    Console.WriteLine("Menor índice da matriz da 1 coluna {0}", MenorIndiceMatriz_D1);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");



   











  }
}