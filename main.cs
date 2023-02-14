using System;

class Program {
  public static void Main (string[] args) {
    bool end = false;
    while(end ==false){
    double gasolina = 0;
    double alcool = 0;
    
    Console.WriteLine("Digite o valor da gasolina: ");
    gasolina = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do alcool: ");
    alcool = double.Parse(Console.ReadLine());

    double combustivel = gasolina / alcool;

    if(combustivel > 0.7){
      Console.WriteLine("Vale a pena gasolina!");
    }
     else if(combustivel < 0.7){
      Console.WriteLine("Vale a pena alcool!");
    } 
    else 
    Console.WriteLine("Tanto faz abastecer com um ou com outro!");

    int opcao;
    Console.WriteLine("Deseja efetuar um novo calculo? Digite: ");
    Console.WriteLine("1 -Continuar | 2- Sair");
    opcao= int.Parse(Console.ReadLine());

      end= opcao ==2;
    
    }
      
    }
}
