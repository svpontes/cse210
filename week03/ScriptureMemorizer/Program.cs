using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        //testing method DisplayReference(string book, string bookName, int chapter, int verse, int endVerse)

        Reference ref1 = new Reference("Book of Mormon", "First Nefi", 3, 7);//No endVerse
        Console.WriteLine(ref1.DisplayReference());//expected output:  [Book of Mormon] First Nefi 3: 7

        Reference ref2 = new Reference("Book of Mormon", "First Nefi", 3, 7, 8);//With endVerse
        Console.WriteLine(ref2.DisplayReference());//expected output:  [Book of Mormon] First Nefi 3: 7-8
    }
}
