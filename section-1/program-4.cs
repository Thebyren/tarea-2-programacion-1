using System;
class Program4{
  public static void Main(){
    const char varChar= 'a';//declaramos el char
    const int varInt = (int)varChar;// lo convertimos en entero
    
    Console.WriteLine("la variable sin parsear es: "+varChar+" | "+varChar.GetType());
    Console.WriteLine("la variable parseada es: "+varInt+" | "+varInt.GetType());
  }
}