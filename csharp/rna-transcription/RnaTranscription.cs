using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        switch (nucleotide)
        {
            case "G":
                return "C";
                break;

            case "C":
                return "G";
                break;

            case "T":
                return "A";
                break;

            case "A":
                return "U";
                break;
        }

        return null;
    }
}