using System;
class Program2{
  public static void Main(){
    const decimal varDecimal= 34234235.23423425m;//declaramos el decimal
    const float varFloat = (float)varDecimal;// lo convertimos en float
    
    Console.WriteLine("la variable sin parsear es: "+varDecimal+" | "+varDecimal.GetType());
    Console.WriteLine("la variable parseada es: "+varFloat+" | "+varFloat.GetType());
  }
}