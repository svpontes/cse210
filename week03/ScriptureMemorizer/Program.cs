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

        //Testing create Scripture object with the first reference and a sample text
        Scripture scripture = new Scripture(ref1, 
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things\n"+
            "which the Lord hath commanded, for I know that the Lord giveth no commandments unto\n" + 
            "the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
  
        //infinite loop. Stop when a break condition is achieved (when scripture.TextIsTotallyHidden()) or user type quit
        while(true){

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress ENTER to hide words or Type 'quit' to exit");
            string input = Console.ReadLine().Trim().ToLower();

            if(scripture.TextIsTotallyHidden()){
                
                Console.WriteLine("\nAll words are hidden! End of the programm.");
                break;
            }

            if (input == "quit"){

                break;
            }

            scripture.hideRandomWords(2);
        } 

    }


}
