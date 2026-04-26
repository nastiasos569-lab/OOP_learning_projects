using System.Text;

public class MMB
{
    public string Encrypt(string input)
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            int x = c;
            x = (x * 1299721) % 256; 
            result.Append((char)x);
        }

        return result.ToString();
    }
}
