using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        char ch = Convert.ToChar(charArray);

        if (input.Contains(ch))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
