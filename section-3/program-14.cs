using System;
using System.Linq;
class program11
{
 public static void Main()
 {
  Console.WriteLine("Escribe algo:");
  
  string frase = Console.ReadLine();
  Console.WriteLine("ingrese la palabra que busca:");
  string palabraBuscada = Console.ReadLine();
  if(palabraBuscada.All(frase.Contains)){
    Console.WriteLine("se encontro la palabra '"+palabraBuscada+"' en '"+frase+"'");
  }else{
    Console.WriteLine("no se encontro la palabra '"+palabraBuscada+"' en '"+frase+"'");
  }

 } 
}
