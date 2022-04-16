using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arabic_nlp
{
    class Word
    {
        public string name { set; get; }
        public string meaning { set; get; }
        public string weight { set; get; }
        public string abstruct { set; get; }
        public string suffix { set; get; }
        public string prefix { set; get; }
        public string root { set; get; }

        public Word(string name, string meaning = null, string weight = null, string abstruct = null, string suffix = "", string prefix = "", string root = null)
        {
            this.name = name;
            this.meaning = meaning;
            this.abstruct = abstruct;
            this.suffix = suffix;
            this.prefix = prefix;
            this.root = root;
        }

        public string getAbstruct()
        {
            this.abstruct = this.name;
            if (this.name.Length >= (this.prefix.Length + this.suffix.Length) && this.name.Length - this.prefix.Length - this.suffix.Length >= 3)
            {
                this.abstruct = name.Substring(this.prefix.Length, this.name.Length - this.prefix.Length - this.suffix.Length );
            }
            return this.abstruct;
        }

        public string getPrefix()
        {
            foreach (string prefix in Prefix.prefixes)
            {
                if (this.name.StartsWith(prefix) == true && this.prefix.Length < prefix.Length && this.name.Length - prefix.Length >= 3)
                {
                    this.prefix = prefix;
                }
            }
            return this.prefix;
        }

        public string getSuffix()
        {
            foreach (string suffix in Suffix.suffixes)
            {
                if (this.name.EndsWith(suffix) == true && this.suffix.Length < suffix.Length && this.name.Length - suffix.Length >= 3)
                {
                    this.suffix = suffix;
                }
            }
            return this.suffix;
        }

        public bool checkWordIfLetter()
        {
            string letter = Letter.letteres.FirstOrDefault(val => val == name);
            if (letter != null)
            {
                this.meaning = "حرف";
                return true;
            }
            return false;
        }

        public bool checkWordIfProper()
        {
            string proper = Proper.proper_names.FirstOrDefault(val => val == name);
            if (proper != null)
            {
                this.meaning = "اسم علم";
                return true;
            }
            return false;
        }

        public void processWord()
        {
           RootBased rootBased = new RootBased();
           bool isProper =  this.checkWordIfProper();
           if (isProper == true)
            {
                return;
            }
            bool isLetter = this.checkWordIfLetter();
            if (isLetter == true)
            {
                return;
            }
            this.getPrefix();
            this.getSuffix();
            this.getAbstruct();
            Weight weight = rootBased.getRoot(this.abstruct);
            if (weight != null)
            {
                this.meaning = weight.type;
                this.root = weight.root;
                return;
            }
            this.abstruct = this.name.Substring(this.prefix.Length);
            weight = rootBased.getRoot(this.abstruct);
            if (weight != null)
            {
                this.suffix = null;
                this.meaning = weight.type;
                this.root = weight.root;
                return;
            }
            this.abstruct = this.name.Substring(0, this.name.Length - this.suffix.Length);
            weight = rootBased.getRoot(this.abstruct);
            if (weight != null)
            {
                this.prefix = null;
                this.meaning = weight.type;
                this.root = weight.root;
                return;
            }
            this.abstruct = this.name;
            weight = rootBased.getRoot(this.abstruct);
            if (weight != null)
            {
                this.prefix = null;
                this.suffix = null;
                this.meaning = weight.type;
                this.root = weight.root;
                return;
            }
        }
    }
}
