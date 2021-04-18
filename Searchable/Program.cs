using System;

namespace Searchable
{
    class Program
    {
        static void Main(string[] args)
        {
            Searchable s = new Searchable("the quick brown fox jumps over the lazy dog");
            Console.WriteLine($"Input string: {s.value}");
            Console.WriteLine($"Number of characters {s.NumOfChars()}");
            Console.WriteLine($"Number of words {s.NumOfWords()}");
            Console.WriteLine($"Occurrences of the character 'o' {s.NumOfXChar('o')}");
            Console.WriteLine($"Occurrences of the word 'the' {s.NumOfXWord("the")}");
            Console.WriteLine($"Last index of the character 'r' {s.LastIndexOf('r')}");
            Console.WriteLine($"Swap every two words: {s.SwapEvery2Words()}");
        }
    }

    class Searchable
    {
        public string value { get; }

        public Searchable(string value)
        {
            this.value = value;
        }

        public int NumOfWords()
        {
            string[] words = value.Split(" ");
            return words.Length;
        }

        public int NumOfChars()
        {
            return value.Length;
        }

        public int NumOfXWord(string word)
        {
            int count = 0;
            string[] words = value.Split(" ");
            foreach (var w in words)
            {
                if (w == word)
                    count++;
            }

            return count;
        }

        public int NumOfXChar(char ch)
        {
            int count = 0;
            foreach (var c in value)
            {
                if (c == ch)
                    count++;
            }

            return count;
        }

        public int LastIndexOf(char ch)
        {
            for (int i = value.Length - 1; i > 0; i--)
            {
                if (value[i] == ch)
                {
                    return i;
                }
            }
            
            return -1;
        }

        public string MostFrequentword()
        {
            return null;
        }

        public string SwapEvery2Words()
        {
            string[] words = value.Split(" ");
            for (int i = 0; i < words.Length - 1; i += 2)
            {
                var temp = words[i];
                words[i] = words[i + 1];
                words[i + 1] = temp;
            }

            return string.Join(" ", words);
        }

    }
}