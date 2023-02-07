
using System;

class Program {
  public static void Main (string[] args) {


// Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever: o maior preço lido e a média aritmética dos preços dos produtos.

Double preco, maiorpreco, soma, media;
String entrada;
  Int16 codigo;
  soma = 0;
  media= 0;
    for (int i = 1;i<=15;i++)
            {
             Console.WriteLine("Codigo do produto: ");
entrada = Console.ReadLine ();
codigo = Int16.Parse(entrada);

Console.WriteLine ("Preço do produto: "); 
entrada = Console.ReadLine ();
preco = Double.Parse(entrada);
      soma = soma + preco;
      }
    media = soma /15;
   Console.WriteLine ("A média dos preços foi: " +media);
     
int maiorpreco = 0;
for(var i = 0; i < 100; i++)
    // se o valor atual da lista for maior que o valor que já tenho
    if(i > maiorpreco);
        // atualiza o valor que ja tenho
        maiorpreco = i;   

   
 maiorpreco = preco;
   }
 
  }