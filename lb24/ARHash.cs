public class ARHash
{
    public int Compute(string input)
    {
        int hash = 0;

        foreach (char c in input)
        {
            hash = (hash + c) * 31;
        }

        return hash;
    }
}