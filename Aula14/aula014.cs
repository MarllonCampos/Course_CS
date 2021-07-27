using System;

class Aula14
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
    if (res >= 60){
      if (res >=90) {
        if(res >= 95 ){
          resultado="Aprovado com super louvor";
        }else {
          resultado="Aprovado com louvor";
        }
      }else {
        resultado="Aprovado";
      }
    
    }else{
      if(res >= 40 ){
        resultado = "Em recuperação";
      }else {
        resultado = "Reprovado";
      }
    }


    Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);


  }
}