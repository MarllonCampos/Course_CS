using System;

class Aula22{

  public static void Main(){
    Console.Title = "Aula 22";
    Console.Clear();
    int[] num=new int[5]{11,22,33,44,55};

    // for (int i =0;i<num.Length; i++) {
    //   Console.WriteLine(num[i]) ;
    // }

    foreach(int n in num) {
      Console.WriteLine(n);
    }

    Console.ReadKey();
    Console.Clear();
  }

}