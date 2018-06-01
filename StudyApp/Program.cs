using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Study Application
 * by Claudia Jarmakowicz. 05/29/2018
 */

namespace StudyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Study Application by Claudia Jarmakowicz";

          

            
            int Score = 0;
            double Points = 0;

            

            Score = Score + (int)Points;

            Player playerOne = new Player();
            playerOne.Gender = "female";
            playerOne.submitName();
            Console.WriteLine("Welcome to the study app," + playerOne.Name + "!\n\n");
            Console.WriteLine("Press Enter to begin!");
            Console.ReadKey();




            //HUD

            playerOne.HUD();



            //five term instances
            Term term01 = new Term();
            term01.Name = "Object";
            term01.Definition = "An instance of a class.";

            Console.WriteLine("Question 1: " + term01.Definition);
            if (Console.ReadLine() == term01.Name)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();


                //Logic to add points
                playerOne.Score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect, the answer is: " + term01.Name);
                Console.ResetColor();
                //Logic to negate points
            }
            Console.WriteLine("Press \"Enter\" for next question.");
            Console.ReadKey();
            Console.Clear();
            playerOne.HUD();

            Term term02 = new Term();
            term02.Name = "Integer";
            term02.Definition = "A whole number.";

            Console.WriteLine("Question 2: " + term02.Definition);
            if (Console.ReadLine() == term02.Name)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
                //Logic to add points
                playerOne.Score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect, the answer is: " + term02.Name);
                Console.ResetColor();
                //Logic to negate points
            }


            Term term03 = new Term();
            term03.Name = "String";
            term03.Definition = "A string of characters.";

            Console.WriteLine("Question 3: " + term03.Definition);
            if (Console.ReadLine() == term03.Name)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
                //Logic to add points
                playerOne.Score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect, the answer is: " + term03.Name);
                Console.ResetColor();
                //Logic to negate points
            }


            Term term04 = new Term();
            term04.Name = "Boolean";
            term04.Definition = "True or false.";

            Console.WriteLine("Question 4: " + term04.Definition);
            if (Console.ReadLine() == term04.Name)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
                //Logic to add points
                playerOne.Score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect, the answer is: " + term04.Name);
                Console.ResetColor();
                //Logic to negate points
            }


            Term term05 = new Term();
            term05.Name = "Double";
            term05.Definition = "A large number that can include a decimal.";

            Console.WriteLine("Question 5: " + term05.Definition);
            if (Console.ReadLine() == term05.Name)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                Console.ResetColor();
                //Logic to add points
                playerOne.Score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect, the answer is: " + term05.Name);
                Console.ResetColor();
                //Logic to negate points
            }

            //color
          



           

            

            Console.ReadKey();
        

        

       
        
            

            

        }
    }
}
