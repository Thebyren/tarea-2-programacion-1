using System;

class program{
public static void Main(){
  int altura;
  int ancho;
  string input;
Console.WriteLine("ingrese la altura del triangulo");
  input = Console.ReadLine();
  altura = int.Parse(input);
Console.WriteLine("ingrese el ancho del triangulo");
  input = Console.ReadLine();
  ancho = int.Parse(input);
  Console.WriteLine("el area del triangulo es:"+((altura*ancho)/2));
}
}