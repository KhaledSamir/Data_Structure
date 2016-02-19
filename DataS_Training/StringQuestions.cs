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

        internal char[] GetAllPermutations(char[] str, int start, int end)
        {
            char[] checkvalue = new char[] { };
            if (start == end)
            {
                Console.WriteLine(str);
            }

            else {
                for (int i = start; i <= end; i++)

                {

                    Swap(ref str[start], ref str[i]);

                    checkvalue = GetAllPermutations(str, start + 1, end);

                    Swap(ref str[start], ref str[i]);

                }
            }

            return checkvalue;
        }

        static void Swap(ref char one, ref char two)
        {
            char temp = one;
            one = two;
            two = temp;
        }

        internal char []  ReplaceWithPerCent20(string mainstr)
        {
            int spaceCount = 0, newLength, i;

            for (i = 0; i < mainstr.Length; i++)
            {
                if (mainstr[i] == ' ')
                {
                    spaceCount++;
                }
            }

            newLength = mainstr.Length + spaceCount * 2;
            char[] str = new char[newLength];
            str[newLength - 1] = '\0';
            for (i = mainstr.Length - 1; i >= 0; i--)
            {
                if (mainstr[i] == ' ')
                {
                    str[newLength - 1] = '0';
                    str[newLength - 2] = '2';
                    str[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else {
                    str[newLength - 1] = mainstr[i];
                    newLength = newLength - 1;
                }
            }

            return str;
        }

        internal string ReplaceWithPerCent202(string mainstr)
        {
            return mainstr.Replace(" ", "%20");
        }

        internal bool IsPermutation(string one, string two) // check if second string is permutation of the first one
        {
            one = one.ToLower().Trim();
            two = two.ToLower().Trim();

            if (one.Length != two.Length) return false;

            one = String.Concat(one.OrderBy(c => c));
            two = String.Concat(two.OrderBy(c => c));

            if (one.Equals(two))
                return true;

            return false;
        }

        internal string CompressString(string str)
        {
            char currentchar = str[0];
            int counter = 0;
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (currentchar == str[i])
                {
                    counter++;
                }

                else
                {
                    result += str[i - 1];
                    result += counter;
                    counter = 0;
                    counter++;
                }
                
                currentchar = str[i];
            }

            return result + str[str.Length - 1] + counter;
        }
    }
}
