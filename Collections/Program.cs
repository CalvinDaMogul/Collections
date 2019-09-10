using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>()
            {
                "asdf",
                "blerg",
                "steve",
                "apple",
                "antelope"
            };

            strings.Add("blerg");
            var rresult = strings.Contains("blarg");

            var wordsBeginningWithA = strings.Where(currentString => currentString.StartsWith("a"));
            var firstWord = strings.FirstOrDefault(currentString => currentString.StartsWith("a"));
            var secondWord = strings.Skip(1).Take(1);

            var anyWordsWithX = strings.Any(currentWord => currentWord.StartsWith("x"));
            var allWordsWithX = strings.Any(currentWord => currentWord.StartsWith("x"));

            var transformed = strings.Select(item => $"item - transformed");

            var LetterAAnimals = strings
                .Where(currentString => currentString.StartsWith("a"))
                .Select(item => new Animal { Name = item });

            var groupedStrings = strings
                .GroupBy(currentString => currentString.First());

            strings.OrderByDescending(currentString => currentString.Last());
            strings.OrderBy(currentString => currentString.Last());

            foreach (var grouping in groupedStrings)
            {
                Console.WriteLine($"I'm looping over the {grouping.Key} group");
                foreach (var currentString in grouping)
                {
                    Console.WriteLine($"{currentString} is in group {grouping.Key}");
                }
            }


            foreach (var currentString in strings)
            {
                Console.WriteLine($"Current string is {currentString}.");
            }

            var alphabetWords = new Dictionary<int,string>();
            alphabetWords.Add(1,"apple");
            alphabetWords.Add(5,"baby");
            alphabetWords.Add(7,"catastrophe");
            //alphabetWords.Add(7,"Other thing");

            var seven = alphabetWords['7'];
            alphabetWords['7'] = "dogastrophe";

            //var keyValues = new List<KeyValuePair<char,string>>();
            foreach (var word in alphabetWords)
            {
                Console.WriteLine($"The current key is {word.Key} and the value is {word.Value}");
            }


            var hashset = new HashSet<Animal>();
            var animal = new Animal { Age = 12, Color = "golden", Name = "tom", Type = "cat" };
           
            hashset.Add(animal);

            


        }
    }

    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
    }
}
