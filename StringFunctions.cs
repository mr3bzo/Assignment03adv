using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03ADV
{
    internal class StringFunctions
    {
        public static int GetCountOfUpperCaseChars(string word)
        {
            int Count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        Count++;
                    }
                }

            }
            return Count;
        }




        public static int GetCountOfLowerCaseChars(string word)
        {
            int Count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        Count++;
                    }
                }

            }
            return Count;
        }
    }
}