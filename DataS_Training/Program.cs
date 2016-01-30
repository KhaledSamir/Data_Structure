using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Alia";
            Console.WriteLine(uniquestring(x));
           // Console.WriteLine('c' - 'a' + 1);
        }

        static bool uniquestring(string str)
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
    }
}
