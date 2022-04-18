using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabic_nlp
{
    class RootBased
    {
        public List<Weight> weights = new List<Weight>()
        {
            new Weight("فعل", "", new int[] {0, 1, 2}, 3, "فعل"),
            new Weight("فلع", "", new int[] {0, 2, 1}, 3, "فعل"),
            new Weight("عفل", "", new int[] {2, 0, 1}, 3, "فعل"),
            new Weight("فعلل", "ل", new int[] {0, 1, 2}, 4, "فعل"),
            new Weight("افتعل", "ات", new int[] {1, 3, 4}, 5, "فعل"),
            new Weight("فاعل", "ا", new int[] {0, 2, 3}, 4, "اسم فاعل"),
            new Weight("انفعل", "ان", new int[] {2, 3, 4}, 5, "فعل"),
            new Weight("استفعل", "است", new int[] {3, 4, 5}, 6, "فعل"),
            new Weight("افتعال", "اتا", new int[] {1, 3, 5}, 6, "اسم"),
            new Weight("مفتعل", "مت", new int[] {1, 3, 4}, 5, "فعل"),
            new Weight("مفعول", "مو", new int[] {1, 2, 4}, 5, "اسم مفعول"),
            new Weight("فعال", "ا", new int[] {0, 1, 3}, 4, "اسم مبالغة"),
            new Weight("فعول", "و", new int[] {0, 1, 3}, 4, "اسم فاعل للمونث"),
            new Weight("فعيل", "ي", new int[] {0, 1, 3}, 4, "اسم فاعل للمذكر"),
            new Weight("مفعال", "ما", new int[] {1, 2, 4}, 5,  "اسم مبالغة"),
            new Weight("مفعيل", "مي", new int[] {1, 2, 4}, 5,  "اسم مبالغة"),
            new Weight("فعلة", "ة", new int[] {0, 1, 2}, 4,  "وقوع الحدث"),
            new Weight("فعليل", "يل", new int[] {0, 1, 2}, 5,  "اسم مبالغة"),
            new Weight("أفعل", "أ", new int[] {1, 2, 3}, 4,  "فعل"),
            new Weight("افعل", "ا", new int[] {1, 2, 3}, 4,  "فعل"),
            new Weight("فعلان", "ان", new int[] {0, 1, 2}, 5,  "جمع"),
            new Weight("فعلى", "ى", new int[] {1, 2, 3}, 4,  "فعل"),
            new Weight("فيعل", "ي", new int[] {0, 2, 3}, 5,  "اسم"),
            new Weight("مفعل", "م", new int[] {1, 2, 3}, 4,  "اسم مكان"),
            new Weight("مفعلة", "مة", new int[] {1, 2, 3}, 5,  "اسم مكان"),
            new Weight("فعيلة", "ية", new int[] {0, 1, 3}, 5,  "اسم مكان"),
            new Weight("فعالة", "اة", new int[] {0, 1, 3}, 5,  "اسم مكان"),
            new Weight("فاعلة", "اة", new int[] {0, 2, 3}, 5,  "اسم مكان"),
            new Weight("فاعول", "او", new int[] {0, 2, 4}, 5,  ""),
            new Weight("تفاعل", "تا", new int[] {1, 3, 4}, 5,  "فعل"),
            new Weight("استفعال", "استا", new int[] {3, 4, 6}, 7,  "فعل"),
            new Weight("تفعل", "ت", new int[] {1, 2, 3}, 4,  "فعل"),
            new Weight("فوعل", "و", new int[] {0, 2, 3}, 4,  ""),
            new Weight("فعيلل", "يل", new int[] {0, 1, 3}, 5,  "اسم مبالغة"),
            new Weight("فعائل", "ائ", new int[] {0, 1, 4}, 5,  "جمع"),
            new Weight("فواعل", "وا", new int[] {0, 3, 4}, 5,  "جمع"),
        };

        public List<string> removeRoot(string word, int[] postions)
        {
            List<string> result = new List<string>();
            char[] c = { word[postions[0]] , word[postions[1]] , word[postions[2]] };
            string root = new string(c);
            result.Add(root);
            string removedLetter = "";
             if (postions[0] > 0)
            {
                removedLetter +=
                word.Substring(0, postions[0]);
            }
            if (+postions[1] > postions[0] +1)
            {
                removedLetter += 
                    word.Substring(postions[0]+1, postions[1] - (postions[0] + 1));
            }
            if (postions[2] >  postions[1] + 1)
            {
                removedLetter +=
                    word.Substring(postions[1]+1, postions[2] - (postions[1]+1));
            }
            if(postions[2]+1 < word.Length)
            {
                removedLetter +=
                word.Substring(postions[2]+1);
            }
            result.Add(removedLetter);
            return result;
        }
        public bool checkRoot(string root)
        {
            string isFound = Root.roots.FirstOrDefault(val => val == root);
            if (isFound != null)
            {
                return true;
            }
            return false;
        }
        public Weight getRoot(string word)
        {
            if (word.Length >= 3)
            {
                foreach (Weight w in this.weights)
                {
                    if (w.number_of_char == word.Length)
                    {
                        List<string> result = this.removeRoot(word, w.root_pos);
                        if (w.deferent_root == result[1] && this.checkRoot(result[0]) == true)
                        {
                            w.root = result[0];
                            return w;
                        }
                    }
                }
            }
            return null;
        }
    }
}
