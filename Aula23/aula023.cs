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
    // public static int BinarySearch(array,valor)
    Console.WriteLine("BinarySearch");
    Console.WriteLine("Elementos do vetor 1");
    foreach (int n in vetor1)
    {
      Console.WriteLine(n);
    }

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
    vetor1.CopyTo(vetor3, 0);
    foreach (int n in vetor3)
    {
      Console.WriteLine(n);
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");


    Console.ForegroundColor = ConsoleColor.Blue;
    // public long GetLongLength(dimensao)
    Console.WriteLine("GetLongLenght");
    long qtdeElementosVetor = vetor1.GetLongLength(0);
    Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");



    Console.ForegroundColor = ConsoleColor.DarkCyan;
    // public get LowerBound(dimensão);
    Console.WriteLine("GetLowerBound");
    int MenorIndiceVetor = vetor1.GetLowerBound(0);
    int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
    Console.WriteLine("Menor índice do vetor1 {0}", MenorIndiceVetor);
    Console.WriteLine("Menor índice da matriz da 1 coluna {0}", MenorIndiceMatriz_D1);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");



    Console.ForegroundColor = ConsoleColor.DarkRed;
    // public int GetUpperBound(dimensão)
    Console.WriteLine("GetUpperBound");
    int MaiorIndiceVetor = vetor1.GetUpperBound(0);
    int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
    Console.WriteLine("Maior índice do vetor1 {0}", MaiorIndiceVetor);
    Console.WriteLine("Maior índice da matriz {0}", MaiorIndiceMatriz_D1);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");


    Console.ForegroundColor = ConsoleColor.DarkGreen;
    // public object GetValue(long índice);
    Console.WriteLine("GetValue");
    int valor0 = Convert.ToInt32(vetor1.GetValue(3));
    int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
    Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
    Console.WriteLine("Valor da linha 1 coluna 3 da matriz: {0}", valor1);

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");


    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    // public static int indexOf(array,valor);
    Console.WriteLine("indexOf");
    int indice1 = Array.IndexOf(vetor1, 3);
    Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");



    Console.ForegroundColor = ConsoleColor.DarkYellow;
    // public static int lastIndexOf(array,valor);
    Console.WriteLine("lastIndexOf");
    int indice2 = Array.LastIndexOf(vetor1, 3);
    Console.WriteLine("Indice do ultimo valor 3: {0}", indice2);

    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");


    // public static void Reverse(array);
    Console.ForegroundColor = ConsoleColor.Blue;
    Array.Reverse(vetor1);
    foreach (int n in vetor1)
    {
      Console.WriteLine(n);
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");



    // public void SetValue(object valor, long pos);
    Console.ForegroundColor = ConsoleColor.Cyan;
    vetor2.SetValue(99, 0);
    for (int i = 0; i < vetor2.Length; i++)
    {
      vetor2.SetValue(0, 1);
    }
    Console.WriteLine("Vetor 2");
    foreach (int n in vetor2)
    {
      Console.WriteLine(n);
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");


    // public static void Sort (array);
    Console.WriteLine("Sort");
    Array.Sort(vetor1);
    Array.Sort(vetor2);
    Array.Sort(vetor3);
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Vetor1");
    foreach (int n in vetor1)
    {
      Console.WriteLine(n);
    }

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\nVetor2");
    foreach (int n in vetor1)
    {
      Console.WriteLine(n);
    }

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nVetor3");
    foreach (int n in vetor1)
    {
      Console.WriteLine(n);
    }


    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("-----------------------------\n");








  }
}