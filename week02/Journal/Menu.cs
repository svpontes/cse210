using System;

public class Menu
{
    public string _userPick;

    public void DisplayMenu()
    {
        Console.WriteLine("\n--- My Journal ---");
        Console.WriteLine("1 - Write");
        Console.WriteLine("2 - Display");
        Console.WriteLine("3 - Save");
        Console.WriteLine("4 - Load");
        Console.WriteLine("5 - Quit");
        Console.Write("Choose an Option: ");
        _userPick = Console.ReadLine();
    }
}
