using System;

public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        string[] colours = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
        int input3 = int.Parse(Console.ReadLine());

        if (input1 <= colours.Length && input2 <= colours.Length && input3 <= colours.Length)
        {
            string i3 = new String ('0', input3);
            int bandValue = int.Parse(input1.ToString() + input2.ToString());
            return bandValue + i3.ToString();
        }
        else
        {
            return "Invalid band values";
        }
    }
}


