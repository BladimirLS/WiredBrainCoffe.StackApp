using System;

namespace WiredBrainCoffe.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new SimpleStack();
            stack.Push(1.8);
            stack.Push(5.4);
            stack.Push(3.9);
        }
    }
}
