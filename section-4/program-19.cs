using System;

class program11
{
 public static void Main()
 {
  Console.WriteLine("escribe la temperatura en grados celsius");
  string celcius = Console.ReadLine();

  double fahrenheit = (double.Parse(celcius)*1.8)+32;
  Console.WriteLine(" el resultado es: "+ fahrenheit);
  
 } 
}
