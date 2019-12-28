//包含min函数的栈
using System.Collections.Generic;

class Solution
{
    Stack<int> stack = new Stack<int>();
    Stack<int> stackmin = new Stack<int>();
    public void push(int node) 
    {
        stack.Push(node);
        if (stackmin.Count > 0)
        {
            if (node < stackmin.Peek())
            {
                stackmin.Push(node);
            }
        } 
        else stackmin.Push(node); 

    }
    public void pop() 
    {
        int node = stack.Pop();
        if (node == stackmin.Peek())
        {
            stackmin.Pop();
        }
    }

    public int top() 
    {
        return stack.Peek();
    }
    public int min() 
    {
        return stackmin.Peek();
    }
}