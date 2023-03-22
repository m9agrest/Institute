class BST
{
    public BST Left = null;
    public BST Right = null;
    public int Index;
    public int Digit;
    public BST(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Digit = array[i];
                Index = i;
            }
            else
                Add(array[i], i);
        }
    }
    public BST(int d, int i)
    {
        Digit = d;
        Index = i;
    }
    public void Add(int d, int i)
    {
        if (d > Digit)
            if (Right != null)
                Right.Add(d, i);
            else
                Right = new BST(d, i);
        else if (d < Digit)
            if (Left != null)
                Left.Add(d, i);
            else
                Left = new BST(d, i);
    }
}
