using System;
using System.Text;

namespace LifeSpot
{
    public class Logger
    {
       
        public static void PrintMessage(Action logMode)
        {
          
            Console.OutputEncoding = Encoding.Unicode;
           
            Console.WriteLine("Логгер запущен");
           
            logMode.Invoke();
        }
        
     
        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
     
        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
      
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}