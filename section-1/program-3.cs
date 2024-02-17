using System;
class Program3{
  public static void Main(){
    const float varFloat= 235.3425f;//declaramos el float
    const int varInt = (int)varFloat;// lo convertimos en entero
    
    Console.WriteLine("la variable sin parsear es: "+varFloat+" | "+varFloat.GetType());
    Console.WriteLine("la variable parseada es: "+varInt+" | "+varInt.GetType());
  }
}