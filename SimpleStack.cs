using System;

namespace WiredBrainCoffe.StackApp
{
    internal class SimpleStack
    {
        private readonly double[] _items;
        private int _currentIndex = -1;
        public SimpleStack()
        {
            _items = new double[10];
        }

        public void Push(double item)
        {
            _currentIndex++;
            _items[_currentIndex] = item;
        }
    }
}