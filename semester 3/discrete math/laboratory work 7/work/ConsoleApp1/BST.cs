using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class BST
    {
        BSTItem Root;
        public void Clear()
        {
            Root = null;
        }
        private void AddRecur(BSTItem cur, int value, int index)
        {
            if (value < cur.Value)
            {
                if (cur.Left == null)
                {
                    cur.Left = new BSTItem(value, index);
                }
                else
                {
                    AddRecur(cur.Left, value, index);
                }
            }
            else if (value > cur.Value)
            {
                if (cur.Rigth == null)
                {
                    cur.Rigth = new BSTItem(value, index);
                }
                else
                {
                    AddRecur(cur.Rigth, value, index);
                }
            }
            else
            {
                cur.ArrayIndices.Add(index);
            }
        }
        public void Add(int value, int index)
        {
            if (Root == null)
            {
                Root = new BSTItem(value, index);
            }
            else
            {
                AddRecur(Root, value, index);
            }
        }
        public bool Search(int value, out List<int> indices, out int interCount)
        {
            BSTItem cur = Root;
            interCount = 0;
            while (cur != null)
            {
                interCount++;
                if (cur.Value == value)
                {
                    indices = cur.ArrayIndices;
                    return true;
                }
                else if (value < cur.Value)
                {
                    cur = cur.Left;
                }
                else if (value > cur.Value)
                {
                    cur = cur.Rigth;
                }
            }
            indices = null;
            return false;
        }
    }
}
