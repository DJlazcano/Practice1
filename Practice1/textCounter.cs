using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class textCounter
    {
        public string inputText;
        public int numWords;
        public int numSentences;
        public int numParagraphs;

        public void readLines()
        {
            string line;
            int lineBlankCount = 0;

            while (true)
            {
               line = Console.ReadLine();
                if(string.IsNullOrEmpty(line)) {
                    
                    lineBlankCount++;

                    if(lineBlankCount >= 2)
                    {
                        break;
                    }
                    this.inputText += line + "\n";
                }
                else
                {
                    lineBlankCount = 0;
                    this.inputText += line + "\n";
                }
            }

            this.inputText = inputText.Trim();
        }

        public void countWords()
        {
            string[] textWords = this.inputText.Split(new char[] {' ', '\t', '\n'},
                                    StringSplitOptions.RemoveEmptyEntries);
            this.numWords = textWords.Length;
        }

        public void countSentences()
        {
            string[] textSentences = this.inputText.Split(new char[] {'.', '!', '?'},
                                    StringSplitOptions.RemoveEmptyEntries);
            this.numSentences = textSentences.Length;
        }

        public void countParagraphs()
        {
            string[] textParagraphs = this.inputText.Split(new string[] { "\n\n" },
                                    StringSplitOptions.RemoveEmptyEntries);
            this.numParagraphs = textParagraphs.Length;
        }

        public void countText()
        {
            countWords();
            countSentences();
            countParagraphs();
        }
    }
}
