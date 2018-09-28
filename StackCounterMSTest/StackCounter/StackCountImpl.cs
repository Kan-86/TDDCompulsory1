using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackCounter
{
    public class StackCountImpl : IStackCountImpl
    {
        public Stack<double> stack = new Stack<double>();

        public void StackNumbers()
        {
            stack.Push(50);
            stack.Push(40);
            stack.Push(10);
        }

        public double AddAll()
        {
            double result = 0;
            while (stack.Count > 0)
            {
                result = result + stack.Pop(); 
            }
            stack.Push(result);
            return result;
        }

        public double AddPop()
        {
            var result = stack.Pop() + stack.Pop();
            stack.Push(result);
            return result;
        }

        public double SubAll()
        {
            var result = stack.Pop() - stack.Pop();
            return result;
        }

        public double MultAll()
        {
            double result = 1;
            while (stack.Count > 0)
            {
                result = result * stack.Pop();
            }
            stack.Push(result);
            return result;
        }

        public double MultPop()
        {
            double result = stack.Pop() * stack.Pop();
            stack.Push(result);
            return result;
        }

        public double Div()
        {
            var result = stack.Pop() / stack.Pop();
            return result;
        }

        public void Clear()
        {
            stack.Clear();
        }

        public double Pop()
        {
            return stack.Pop();
        }

        public void Push(double x)
        {
            stack.Push(x);
        }

        public double Top()
        {
            return stack.Peek();
        }
    }
}
