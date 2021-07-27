using System;

class Aula13
{
  static void Main()
  {

    int n1, n2, n3, n4, res;
    n1 = n2 = n3 = n4 = res = 0;
    string resultado;

    Console.Write("Escreva a nota do primeiro semestre: ");
    n1 = int.Parse(Console.ReadLine());

    Console.Write("Escreva a nota do segundo semestre: ");
    n2 = int.Parse(Console.ReadLine());

    Console.Write("Escreva a nota do terceiro semestre: ");
    n3 = int.Parse(Console.ReadLine());

    Console.Write("Escreva a nota do quarto semestre: ");
    n4 = int.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;

    // Aprovado >= 60
    // Recuperação > 40 < 59 
    // Reprovado < 40
    if (res < 40){
      resultado = "Reprovado";
    }
    else if (res < 60){
      resultado = "Recuperação";
    }
    else{
      resultado = "Aprovado";
    }


    Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);


  }
}