using System;
using System.Collections.Generic;
using System.Text;

namespace StackCounter
{
    public interface IStackCountImpl
    {
        //Adds doubles to stack
        void Push(double x);
        //Remove the top element in stack and return value
        void Pop();
        //This will return the top stack without removing it
        double Top();
        //This will clear the stack
        void Clear();
        //Addition stack
        double AddAll();
        //Addition pop
        double AddPop();
        //Division stack
        double Div();
        //Multiples all stack
        double MultAll();
        //Multiples pop stack
        double MultPop();
        //Substract all stack
        double SubAll();
    }
}
