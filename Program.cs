// See https://aka.ms/new-console-template for more information

//Destinations Array
string[] destinations = {"Reptar World", "Glove World", "Atlantis", "Inner Earth"};

Random rand = new Random();
int index = rand.Next(destinations.Length);



Console.WriteLine("Hello, Welcome to Your Random Day Trip Generator! Please Choose a Destination!");
Console.WriteLine($"Your First Random Destination Chosen for you is {destinations[index]}, Do You Like This Place?(Y/N)");
string inputChoice = Console.ReadLine();
Console.WriteLine($"You Chose {inputChoice}!");
switch(inputChoice) 
{
  case "Y":
    Console.WriteLine("Great Choice! Lets See What Snacks Are There!");
    break;
  case "N":
    Console.WriteLine($"Your Next Choice is {destinations[index]}, Good Choice? (Y/N)");
    string inputChoice2 = Console.ReadLine();
    Console.WriteLine($"You chose {inputChoice2}");
    if(inputChoice2 == "Y")
    {
        Console.WriteLine("You Choose The Best Spot! Lets See What Food Options You Have There! ");
    } else if (inputChoice2 == "N")
    {
        Console.WriteLine($"Your Next Option Is: {destinations[index]}, Is This Your Choice?");
        string inputChoice3 = Console.ReadLine();
        Console.WriteLine($"You Chose {inputChoice3}!");
        if (inputChoice3 == "Y")
        {
            Console.WriteLine("Great Lets Move Along!");
        } else
        {
            Console.WriteLine("I have No Other Options :( , Lets Start Over!");
        }

    } else
    {
        Console.WriteLine($"Your Last Option Is: {destinations[index]}");
    }
    break;
  default:
    Console.WriteLine("Thats not a choice! Try Again!");
    break;
}