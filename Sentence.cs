using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabic_nlp
{
    class Sentence
    {
        public List<Word> words = new List<Word>();
        public string sentence;

        public Sentence(string sentence)
        {
            this.sentence = sentence;
            string[] words = this.sentence.Split(' ');
            foreach(string word in words) {
                this.words.Add(new Word(word));
            }
            this.processSentence();
        }

        public void processSentence()
        {
            foreach (Word word in this.words)
            {
                word.processWord();
            }
        }

        public void print(MetroListView listView)
        {
            foreach (Word word in this.words)
            {
            }
        }
    }
}
