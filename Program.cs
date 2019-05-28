using System;
using System.Collections.Generic;

namespace Dictionaries_about_Words
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

            // Create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "Alex");
            excitedWord.Add("definintion", "awesome");
            excitedWord.Add("part of speech", "noun");
            excitedWord.Add("example sentence", "Alex is cool!");

            // Add Dictionary to your `dictionaryOfWords` list
                dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> notexcitedWord = new Dictionary<string, string>();
            notexcitedWord.Add("word", "Jameka");
            notexcitedWord.Add("definition", "wierd");
            notexcitedWord.Add("part of speech", "noun");
            notexcitedWord.Add("example sentence", "Jameka is mean!");
            
            dictionaryOfWords.Add(notexcitedWord);

            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary <string, string> dictionary in dictionaryOfWords) 
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair <string, string> wordData in dictionary)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }
        }
    }
}
