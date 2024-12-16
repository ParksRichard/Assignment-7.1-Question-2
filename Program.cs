/*
You are given two strings word1 and word2. Merge the strings 
by adding letters in alternating order, starting with word1. 
If a string is longer than the other, append the additional letters 
onto the end of the merged string.Return the merged string.
*/

namespace Assignment_7._1_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The organizing hardcoded words program:");
            Console.WriteLine("");

            //hardcode words numero uno
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine("Hardcode word numero uno:");
            Console.WriteLine(Merge(word1, word2));

            Console.WriteLine("");

            //hardcode words numero dos
            word1 = "ab";
            word2 = "pqrs";
            Console.WriteLine("Hardcode word numero dos:");
            Console.WriteLine(Merge(word1, word2)); 
        }
        static string Merge(string word1, string word2)
        {
            int i = 0, j = 0;
            int len1 = word1.Length, len2 = word2.Length;
            var merged = new System.Text.StringBuilder(); //string builder!

            //merging words
            while (i < len1 && j < len2)
            {
                merged.Append(word1[i++]);
                merged.Append(word2[j++]);
            }
            return merged.ToString();
        }
    }
}
