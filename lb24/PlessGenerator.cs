using System;
using System.Text;

public class PlessGenerator
{
    public string Generate(int count)
    {
        long seed = DateTime.Now.Ticks;
        StringBuilder nums = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            seed = (seed * 1664525 + 1013904223) % (long)Math.Pow(2, 32);
            nums.Append(seed % 100 + " ");
        }

        return nums.ToString();
    }
}