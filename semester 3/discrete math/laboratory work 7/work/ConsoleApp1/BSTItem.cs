using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class BSTItem
    {
        public int Value;
        public List<int> ArrayIndices;
        public BSTItem Left;
        public BSTItem Rigth;
        public BSTItem(int value, int arrayIndex)
        {
            Value = value;
            ArrayIndices = new List<int>();
            ArrayIndices.Add(arrayIndex);
        }
    }
}