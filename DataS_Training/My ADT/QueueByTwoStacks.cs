using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataS_Training.My_ADT
{
    public class QueueByTwoStacks
    {
        private Stack<string> stk1;

        private Stack<string> stk2;

        public QueueByTwoStacks()
        {
            stk1 = new Stack<string>();
            stk2 = new Stack<string>();
        }
        internal void Enque(string q)
        {
            stk1.Push(q);
        }

        internal string Deque()
        {
            while (stk1.Count != 0)
                stk2.Push(stk1.Pop());

            return stk2.Pop();
        }
    }
}