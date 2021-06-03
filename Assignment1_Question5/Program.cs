using System;
using System.Text;

namespace Assignment1_Question5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Q5:");
            Console.WriteLine("Enter the First Word:");
            String word1 = Console.ReadLine();//input string 1
            Console.WriteLine("Enter the Second Word:");
            String word2 = Console.ReadLine();//input string 2
            String merged = MergeAlternatively(word1, word2);
            Console.WriteLine("The Merged Sentence fromed by both words is {0}", merged);//merged string
      
        }
        private static string MergeAlternatively(string word1 , string word2)//returns string
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)//Using condition to get the length of string
            {

                //If condition executes one after the other- so first string comes First.
                //Check The length of First string and start appending the first letter from here
                if (i < word1.Length)//
                    stringBuilder.Append(word1[i]);//Appending the i'th character in string 1

                //check the length of second string and append the letter of string 2 
                if (i < word2.Length)
                    stringBuilder.Append(word2[i]);//appending the i'th character in string 2
                //Exits once both the strings are appended according to length
            }

            string result = stringBuilder.ToString();
            return result;//returning the Resultant String.

        }
    }
    //for(int i = 0; i < words1.Length; i++)
    //{

    //    for(int j= 0;j<words2.Length; j++)
    //    {
    //        s = string.Concat(words1[i], words2[j]);

    //    }


    //}
    //Console.WriteLine(s);
}
