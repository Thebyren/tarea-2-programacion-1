using System;

class ejercicio{
  static void Main(){
    int contador=0;
    Console.WriteLine("ingresa la palabra para poder contar sus vocales");
    
    string frase = Console.ReadLine();
    foreach (char letra in frase.ToLower())
    {
    switch (letra)
    {
      case 'a': 
        contador += 1;
        break;
      case 'e': contador+=1;
        break;
      case 'i': contador+=1;
        break;
      case 'o': contador+=1;
        break;
      case 'u': contador+=1;
        break;
      default:
        break;
    }
    
    }
    Console.WriteLine("el total de vocales es: "+contador);
  }
}