using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabic_nlp
{
    class Word
    {
        public string name { set; get; }
        public string root { set; get; }
        public string meaning { set; get; }

        public Word(string name, string meaning = null, string root = null)
        {
            this.name = name;
            this.meaning = meaning;
            this.root = root;
        }
    }
}
