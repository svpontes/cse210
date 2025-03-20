using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        //testing method DisplayReference(string book, string bookName, int chapter, int verse, int endVerse)

        Reference ref1 = new Reference("Book of Mormon", "First Nefi", 3, 7, 8);//
        Console.WriteLine(ref1.DisplayReference());
    }
}
