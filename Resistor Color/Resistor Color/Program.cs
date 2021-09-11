using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colors = Colors();
        int index = Array.IndexOf(colors, color);
        return index;
    }

    public static string[] Colors()
    {
        string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return colors;
    }
}