using System;

namespace Color_Ghost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ghost ghost = new Ghost();
            Console.WriteLine(ghost.GetColor());
        }
    }
}


public class Ghost
{

    public Ghost() => color = availableColor[new Random().Next(0, availableColor.Length)];
    public string GetColor() { return color; }

    private string[] availableColor = { "yellow", "white", "purple", "red" };
    public string color;
}