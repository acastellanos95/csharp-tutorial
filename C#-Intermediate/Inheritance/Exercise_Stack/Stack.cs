using System;
using System.Collections;

namespace Exercise_Stack
{
    public class Stack
    {
        private ArrayList stack = new ArrayList();

        public void Push(object obj)
        {
            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0)
                return null;
            object LastItem = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return LastItem;
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}