using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingInterviewPracticeProblems
{
    public class Anagrams
    {
        public bool AreTwoStringsAnagrams(string strOne, string strTwo)
        {
            if(strOne.Count() != strTwo.Count()) return false;
            var hashOne = CreateHashtable(strOne);
            var hashTwo = CreateHashtable(strTwo);
            return CompareHashtable(hashOne, hashTwo);
        }

        private bool CompareHashtable(Hashtable hashOne, Hashtable hashTwo)
        {
            if (hashOne.Count != hashTwo.Count) return false;

            foreach (DictionaryEntry h in hashOne)
            {
                if ((int)h.Value != (int)hashTwo[h.Key]) return false;
            }
            return true;
        }

        private Hashtable CreateHashtable(string str)
        {
            var hash = new Hashtable();

            foreach (char c in str)
            {
                if (hash.ContainsKey(c))
                {
                    hash[c] = (int)hash[c] + 1;
                }
                else
                {
                    hash[c] = 1;
                }
            }

            return hash;
        }

        public bool AreStringsAnagrams(string strOne, string strTwo)
        {
            if (strOne.Count() != strTwo.Count()) return false;
            var dictOne = CreateDictionary(strOne);
            var dictTwo = CreateDictionary(strTwo);
            return CompareDictionary(dictOne, dictTwo);
        }

        private bool CompareDictionary(Dictionary<char, int> dictOne, Dictionary<char, int> dictTwo)
        {
            if(dictOne.Count != dictTwo.Count) return false;

            foreach (var (k,v) in dictOne)
            {
                if(v != dictTwo[k]) return false;
            }
            return true;
        }

        private Dictionary<char, int> CreateDictionary(string str)
        {
            var dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] += 1;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            return dict;
        }
    }
}
