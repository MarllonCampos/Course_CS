using System;

class Aula21
{

  public static void Main()
  {
    Console.Title = "Aula 21";
    Console.Clear();

    string senha = "919191";
    string kSenha = "";
    int tentativas = 0;

    do
    {

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Por favor, escreva a senha");
      kSenha = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.Gray;



      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.Clear();
      Console.WriteLine("Senha Incorreta");
      tentativas++;
      Console.ForegroundColor = ConsoleColor.Gray;

    } while (senha != kSenha);

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Acesso garantido - Numero de Tentativas: {0}", tentativas);
    Console.ForegroundColor = ConsoleColor.Gray;



    Console.ReadKey();
    Console.Clear();
  }

}