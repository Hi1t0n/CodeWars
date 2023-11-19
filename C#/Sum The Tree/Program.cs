using System;

namespace Sum_The_Tree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(Kata.SumTree(new Node(10, new Node(1), new Node(2))));
        }
    }
}

public class Node
{  
    public int Value;  
    public Node Left;  
    public Node Right;
    
    public Node(int value, Node left = null, Node right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}  

public static class Kata
{
    public static int SumTree(Node root)
    {
        if(root is null){
            return 0;
        }
        return root.Value + SumTree(root.Left) + SumTree(root.Right);
    }
}