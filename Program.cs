using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{

    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            while (run == true)
            {
                Console.WriteLine("Enter a word to be translated");
                string input1 = Console.ReadLine();
                string newInput = getWord(input1.ToLower());
                Console.WriteLine("Your Pig Latin Word is " + newInput);
                run = Continue();
            }
   
        }

        public static string getWord(string x)
        {

            if (x.StartsWith("a") || x.StartsWith("e") || x.StartsWith("i") || x.StartsWith("o") || x.StartsWith("u"))
            {
                string newInput = string.Concat(x + "way");
                return newInput;
            }

            else
            {
                string input1 = getConsonant(x);
                string newInput = input1.Replace("way", "ay");
                return newInput;
            }
        }
              
              
        public static string getConsonant(string y)
        {
            string sub = y.Substring(1);
            string firstLetter = y.Substring(0, 1);
            string newWord2 = (sub + firstLetter);
            string input = getWord(newWord2);
            return input;
        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Do you want to translate another word? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
    }
}
         
     

