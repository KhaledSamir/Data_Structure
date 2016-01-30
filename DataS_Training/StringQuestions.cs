using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS_Training
{
    public class StringQuestions
    {

        internal bool uniquestring(string str)
        {
            if (str.Length > 256) return false;

            bool[] chars = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];

                if (chars[val])
                    return false;

                chars[val] = true;
            }

            return true;
        }

        internal void GetAllPermutations(char[] str, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(str);
            }

            else {
                for (int i = start; i <= end; i++)

                {

                    Swap(ref str[start], ref str[i]);

                    GetAllPermutations(str, start + 1, end);

                    Swap(ref str[start], ref str[i]);

                }
            }
        }

        static void Swap(ref char one, ref char two)
        {
            char temp = one;
            one = two;
            two = temp;
        }
    }
}
