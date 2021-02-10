using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] charArr = input.ToCharArray();
        Array.Reverse(charArr);
        return new string (charArr);
    }
}