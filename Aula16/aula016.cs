using System;

class Aula16 {

  static void Main() {

    int tempo=0;
    char escolha;
    inicio:

    Console.Clear();

    Console.WriteLine("Belo Horizonte-MG a Vitória-ES");
    Console.WriteLine("Escolha o transporte: ");
    Console.WriteLine("[a] | Avião");
    Console.WriteLine("[c] | Carro");
    Console.WriteLine("[o] | Onibus");
    escolha=char.Parse(Console.ReadLine());

    switch(escolha){
      case 'a':
      case 'A':
        tempo=50;
        break;

      case 'c':
      case 'C':
        tempo=480;
        break;

      case 'o':
      case 'O':
        tempo=660;
        break;

      default:
        tempo=-1;
        break;
    } 

    if(tempo < 0) {
      Console.WriteLine("Transporte inválido");
    }else {
      Console.WriteLine("\nPara o transporte escolhido o tempo é {0} minutos", tempo);
    }

    refazer:
    Console.WriteLine("Deseja realizar a operação novamente?");
    Console.WriteLine("[s] | Sim");
    Console.WriteLine("[n] | Não");
    escolha=char.Parse(Console.ReadLine());

    switch(escolha){
      case 's':
      case 'S':
        goto inicio;
        break;

      case 'n':
      case 'N':
        Console.Clear();
        Console.Write("Fim do programa");
        break;

      default:
        Console.Clear();
        Console.WriteLine("Você digitou uma pergunta inválida refazendo a pergunda");
        goto refazer;


    }

  }
}