using System;
using System.Collections;

namespace wordShifter
{
    
    class extendString // this class extend string functionalities 
    {
        private string source;

        public extendString(string input)
        {
            source = input;
        }
        public void shiftWords()
        {
            ArrayList wordList = new ArrayList();
            string word = "";
            int i = 0;
            while (source[i] == ' ' && i < source.Length) i++;

            while (i < source.Length)
            {
                if (Char.IsLetterOrDigit(source[i]))
                {
                    word += source[i];
                    ++i;
                    while (i < source.Length && Char.IsLetterOrDigit(source[i]))
                    {
                        word += source[i];
                        ++i;
                    }

                    if (word.Length > 1) wordList.Add(word);

                    word = "";
                }
                ++i;
            }

            int swapI = 0, swapJ = 1;


            while (swapI < wordList.Count && swapJ < wordList.Count)
            {
                string temp = (string)wordList[swapI];
                wordList[swapI] = wordList[swapJ];
                wordList[swapJ] = temp;

                swapI += 2;
                swapJ += 2;
            }

            foreach (var w in wordList)
                Console.Write(w + " ");

            Console.WriteLine();

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            new extendString("can you succeed?").shiftWords();
        }
    }
}
