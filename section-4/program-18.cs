using System.Security.AccessControl;
using System;

class program{

public static void Main(){

  double result,x1, y1,x2,y2;
  string input;
  try
  {
    Console.WriteLine("ingrese x del primer punto");
  input = Console.ReadLine();
  x1 = float.Parse(input);
  Console.WriteLine("ingrese y del primer punto");
  input = Console.ReadLine();
  y1 = float.Parse(input);
  Console.WriteLine("ingrese x del segundo punto");
  input = Console.ReadLine();
  x2 = float.Parse(input);
  Console.WriteLine("ingrese y del segundo punto");
  input = Console.ReadLine();
  y2 = float.Parse(input);
  
  }
  catch(System.Exception){
    Console.WriteLine("error al ingresar un numero");
    
    throw;
  }
  result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));  
  Console.WriteLine("la distancia entre ambos puntos es: "+result);
}

}