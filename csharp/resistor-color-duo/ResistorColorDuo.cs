using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] colours = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());

        if (input1 <= colours.Length && input2 <= colours.Length)
        {
            int result = int.Parse(input1.ToString() + input2.ToString());
            return result;
        }
        else
        {
            return int.Parse("Invalid band values"); 
        }
    }
}
