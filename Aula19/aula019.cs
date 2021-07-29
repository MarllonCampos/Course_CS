using System;

class Aula19{

  public static void Main() {
    Console.Clear();
    Console.Title = "Aula19";

    int[] num = new int[10];

    for(int i=0;i < num.Length; i++) {
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      num[i] = i+1;
      Console.WriteLine("Posição: {0} Valor: {1} ", i, num[i]);





      if (i == num.Length) {
        Console.ForegroundColor = ConsoleColor.Cyan;
      }

    }
      Console.ReadKey();
      Console.Clear();
  }
}