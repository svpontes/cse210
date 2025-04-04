public class Menu{
    private ListingActivity _listingActivity;

    public Menu(){

        _listingActivity = new ListingActivity();
    }

    public void DisplayMenu(){

        while (true){

            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. View stored answers and questions");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string userChoice = Console.ReadLine();

            switch (userChoice){
                
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectingActivity().Run();
                    break;
                case "3":
                    _listingActivity.Run();
                    break;
                case "4":
                    DisplayEntries();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    private void DisplayEntries(){

        Console.Clear();
        List<Entry> storedEntries = _listingActivity.GetEntries();

        if (storedEntries.Count == 0){

            Console.WriteLine("No entries found.");
        }
        else {

            Console.WriteLine("\nStored Entries:\n");

            foreach (var entry in storedEntries){
                
                Console.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}
