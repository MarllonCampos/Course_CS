using System;

class Aula20{

  public static void Main() {
    Console.Clear();
    Console.Title = "Aula20";

    int[] num = new int[10];

    int i=num.Length - 1;
    while(i >= 0 ) {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      num[i] = i+1;
      Console.WriteLine("Posição: {0} Valor: {1} ", i, num[i]);



      i--;

      if (i == num.Length) {
        Console.ForegroundColor = ConsoleColor.Cyan;
      }
    }
      Console.ReadKey();
      Console.Clear();
  }
}