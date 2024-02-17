using System;
class Program1{
  public static void Main(){
    const int varInt= 235;//declaramos el Int
    const float varFloat = (float)varInt;// lo convertimos en float
    
    Console.WriteLine("la variable sin parsear es: "+varInt+" | "+varInt.GetType());
    Console.WriteLine("la variable parseada es: "+varFloat+" | "+varFloat.GetType());
  }
}