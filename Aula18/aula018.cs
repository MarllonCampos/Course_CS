using System;

class Aula18
{

  public static void Main()
  {
    Console.Clear();

    Console.Title = "Aula18";

    int[,] n = new int[3,5];
    int[,] num = new int[2,2]{{10,20},{30,40}};
    string nome;
    n[0,0] = 10;
    n[0,1] = 20;
    n[0,2] = 30;
    n[0,3] = 40;
    n[0,4] = 50;


    n[1,0] = 60;
    n[1,1] = 70;
    n[1,2] = 80;
    n[1,3] = 90;
    n[1,4] = 15;

    n[2,0] = 25;
    n[2,1] = 35;
    n[2,2] = 45;
    n[2,3] = 55;
    n[2,4] = 65;
   
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Primeira Matriz");
    Console.Write(n[0,0]+ " ");
    Console.Write(n[0,1]+ " ");
    Console.Write(n[0,2]+ " ");
    Console.Write(n[0,3]+ " ");
    Console.Write(n[0,4]+ "\n");

    Console.Write(n[1,0]+ " ");
    Console.Write(n[1,1]+ " ");
    Console.Write(n[1,2]+ " ");
    Console.Write(n[1,3]+ " ");
    Console.Write(n[1,4]+ "\n");

    Console.Write(n[2,0]+ " ");
    Console.Write(n[2,1]+ " ");
    Console.Write(n[2,2]+ " ");
    Console.Write(n[2,3]+ " ");
    Console.Write(n[2,4]+ "\n");
    Console.ForegroundColor = ConsoleColor.Gray;


    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nSegunda Matriz");
    Console.Write(num[0,0]+ " ");
    Console.WriteLine(num[0,1]);

    Console.Write(num[1,0]+ " ");
    Console.Write(num[1,1]+ "\n");


    
    Console.ForegroundColor = ConsoleColor.Gray;


    
    
    Console.ReadKey();


    Console.Clear();

  }

}