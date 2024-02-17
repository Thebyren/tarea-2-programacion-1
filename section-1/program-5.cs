using System;
class Program5{
  public static void Main(){
    const int varInt = 54;// declaramos el char
    const char varChar= (char)varInt;//lo convertimos en char
    
    Console.WriteLine("la variable sin parsear es: "+varInt+" | "+varInt.GetType());
    Console.WriteLine("la variable parseada es: "+varChar+" | "+varChar.GetType());
  }
}