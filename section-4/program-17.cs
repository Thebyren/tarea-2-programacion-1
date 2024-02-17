using System;

class program{
public static void Main(){
  float radio;
  string input;

  Console.WriteLine("ingrese el diametro del circulo");
  input = Console.ReadLine();
  radio = float.Parse(input);
  Console.WriteLine("el area es: "+(Math.PI * 4 * (radio*radio)));
}
}