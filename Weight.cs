using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabic_nlp
{
    class Weight
    {
        public string weight { set; get; }
        public string deferent_root {  set; get;}
        public int[] root_pos { set; get; }
        public int number_of_char { set; get; }
        public string type { set; get; }
        public string root { set; get; }
        public Weight(string weight = null, string deferent_root = null, int[] root_pos = null, int number_of_char = 0, string type = null)
        {
            this.weight = weight;
            this.deferent_root = deferent_root;
            this.root_pos = root_pos;
            this.number_of_char = number_of_char;
            this.type = type;
        }
    }
}
