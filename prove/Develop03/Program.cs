using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "scripture.txt"; //This will load scriptures from the scripture.txt file

        Scripture scriptures = new Scripture(filePath);
        scriptures.DisplayScriptures();
    }
}