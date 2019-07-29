using System;
using System.Collections.Generic;

namespace dictionaryListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
    You want to track the following about each word:
        word, definition, part of speech, example sentence

    Example of one dictionary in the list:
    {
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    }
*/

            // Create dictionary to represent a few words
            // Dictionary is a class. The KeyValuePair are both strings. The Dictionary is named 'excitedWord'
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            // The dictionary'excitedWord' has the Add method run on it. A KeyValuePair is made
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // A foreach loop is run on the KeyValuePair of the dictionary excitedWord

            foreach (KeyValuePair<string, string> wor in excitedWord)
            {
                Console.WriteLine($"{wor.Key}: {wor.Value}");
            }


        }
    }
}
