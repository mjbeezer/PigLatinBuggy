using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            //this is a mess, input being stored and then passed around to too many variables.
            //Once input is stored in one value, that value should then be used
            //code seems out of order and doesnt follow the way the information should flow
           
            /*string userInput = GetInput("Please input a word or sentence to translate to pig Latin");

            string translation = ToPigLatin(userInput);
            Console.WriteLine(translation);*/

            //should look like this
            Console.WriteLine("Pleas input a word or sentence to translate to pig latin.");//sentance will not work since I did not add any code to split the string
            string userInput = Console.ReadLine().ToLower().Trim();
            string translation = ToPigLatin(userInput);
            Console.WriteLine(translation);//this doesnt actually translate
        }

        //this method isnt needed, easier to get from code in main
        /*public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }*/

        public static string ToPigLatin(string word)//remove second foreach loop
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                if (word.Contains(c))
                {
                    Console.WriteLine("That word has special characters, we will return it as is");
                    return word;
                }
                
                foreach (char i in vowels)//word starts with vowel
                {
                    if (word[0] == i)
                    {
                        return word + "way";
                    }
                }

                foreach(char x in word)
                {
                    if (!word.Contains(c))
                    {
                        return word;
                    }
                }
            }

            string piggy = word.Substring(word.IndexOfAny(vowels));
            string bacon = word.Substring(0, word.IndexOfAny(vowels));
            return piggy + bacon + "ay";
        }
            //this code below here is a mess and unorganized
            /*static bool IsVowel(char c)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                return c.ToString() == vowels.ToString();
            }*/


            /* bool noVowels = true;
             foreach(char letter in word)
             {
                 if (IsVowel(letter))
                 {
                     noVowels = false;
                 }
             }

             if (noVowels)
             {
                 return word; 
             }

             char firstLetter = word[0];
             string output = "placeholder";
             if (IsVowel(firstLetter) == true)
             {
                 output = word + "ay";
             }
             else
             {
                 int vowelIndex = -1;
                 //Handle going through all the consonants
                 for (int i = 0; i <= word.Length; i++)
                 {
                     if (IsVowel(word[i]) == true)
                     {
                         vowelIndex = i;
                         break;
                     }
                 }

                 string sub = word.Substring(vowelIndex + 1);
                 string postFix = word.Substring(0, vowelIndex -1);

                 output = sub + postFix + "ay";
             }
             return output;*/
        
    }
}
