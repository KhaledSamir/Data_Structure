using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataS_Training.My_ADT;

namespace DataS_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "ABC";
            StringQuestions sq = new StringQuestions();
            // sq.GetAllPermutations(x.ToCharArray() , 0 , x.Length -1);\\

            QueueQuestions qq = new QueueQuestions();
            QueueByTwoStacks test = new QueueByTwoStacks();

            test.Enque("1");
            test.Enque("2");
            test.Enque("3");
            test.Enque("4");

            Console.WriteLine(test.Deque());
            // Console.WriteLine('c' - 'a' + 1);
        }

    }
}
