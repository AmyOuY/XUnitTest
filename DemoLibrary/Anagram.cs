using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Anagram
    {
        public static bool IsAnagram(string s1, string s2)
        {
            string s1Lower = s1.ToLower();
            string s2Lower = s2.ToLower();

            if (s1Lower.Equals(s2Lower)) return false;

            int[] count1 = new int[256];
            int[] count2 = new int[256];

            foreach (char c in s1Lower)
            {
                if (c > 255)
                {
                    throw new ArgumentException("string contains non-ASCII codes", "string 1");
                }

                if (c != ' ' && c != ',')
                {
                    count1[c]++;
                }  
            }

            foreach (char c in s2Lower)
            {
                if (c > 255)
                {
                    throw new ArgumentException("string contains non-ASCII codes", "string 2");
                }

                if (c != ' ' && c != ',')
                {
                    count2[c]++;
                }
                
            }

            for (int i = 0; i < 256; i++)
            {
                if (count1[i] != count2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
