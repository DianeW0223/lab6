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

            // This will run as long as you are continuing.
            while (run == true)
            {
                Console.WriteLine("Enter a word to be translated");
                string input1 = Console.ReadLine();
                //This triggers the getWord method and translates it to lowercase.
                string newInput = getWord(input1.ToLower());
                // This gives your final output.
                Console.WriteLine("Your Pig Latin Word is " + newInput);
                run = Continue();
            }
   
        }
        // This method checks for if the word starts with a vowel and if it doesn't it will trigger the getConsonant method.
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
              
              //This is the getConsonant method that will run until the word starts with a vowel.
        public static string getConsonant(string y)
        {
            string sub = y.Substring(1);
            string firstLetter = y.Substring(0, 1);
            string newWord2 = (sub + firstLetter);
            string input = getWord(newWord2);
            return input;
        }

        //This is the continue method that will run at the end of translating each word.
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
         
     

