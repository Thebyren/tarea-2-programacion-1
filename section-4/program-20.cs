using System;

class program11
{
 public static void Main()
 {
  Console.WriteLine("escribe la temperatura en grados fahrenheit");
  string fahrenheit = Console.ReadLine();

  double celsius = (double.Parse(fahrenheit)-32)*1.8;
  Console.WriteLine(" el resultado es: "+ celsius);
  
 } 
}
