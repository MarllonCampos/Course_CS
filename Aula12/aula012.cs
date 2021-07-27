using System;

class Aula12
{
  static void Main()
  {

    int n1,n2,n3,n4,res;
    n1=n2=n3=n4=res=0;
    string resultado = "Reprovado";

    Console.Write("Escreva a nota do primeiro semestre: ");
    n1 = int.Parse(Console.ReadLine());

    Console.Write("Escreva a nota do segundo semestre: ");
    n2 = int.Parse(Console.ReadLine());

    Console.Write("Escreva a nota do terceiro semestre: ");
    n3 = int.Parse(Console.ReadLine());

    Console.Write("Escreva a nota do quarto semestre: ");
    n4 = int.Parse(Console.ReadLine());

    res = n1+n2+n3+n4;

    
    if (res >= 60){
      resultado = "Aprovado";
    }


    Console.WriteLine("Resultado: {0}", resultado);
    Console.WriteLine("O resultado total das notas foi de {0}", res);


  }
}