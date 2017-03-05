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
            MyLinkedList LL = new MyLinkedList();
            LL.Add(1);
            LL.Add(2);
            LL.Add(3);

            Console.WriteLine(LL.Dequeue());
           // LL.RemoveDuplicates();
            LL.Travese();
        }


        //string x = "ABC";
        //StringQuestions sq = new StringQuestions();
        //string one = "ABC  ";
        //string two = "Cba";
        ////sq.GetAllPermutations(x.ToCharArray() , 0 , x.Length -1);
        ////Console.WriteLine(sq.IsPermutation(one, two));
        //Console.WriteLine(sq.CompressString("aabcccccaaa"));

        //QueueQuestions qq = new QueueQuestions();
        //QueueByTwoStacks test = new QueueByTwoStacks();

        //test.Enque("1");
        //test.Enque("2");
        //test.Enque("3");
        //test.Enque("4");

        //Console.WriteLine(test.Deque());
        // Console.WriteLine('c' - 'a' + 1);
    }
}
