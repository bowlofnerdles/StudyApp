using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyApp
{
    public class Player
    {
        public string Gender;
        public string Name;
        public int Score;
        
        public void HUD()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(Name);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("::");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Score =  " + Score + "\n");  //Have to fix to get points to update in HUD
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================================================\n\n\n\n");
            Console.ResetColor();
        }
       

        public void Guess()
        {
          

        }

        public void submitName()
        {
            
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("");
           


        }

        public void Pause()
        {
            
        }
    }
}