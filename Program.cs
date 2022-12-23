// See https://aka.ms/new-console-template for more information

//Destinations Array
string[] destinations = {"Reptar World", "Glove World", "Atlantis", "Inner Earth"};

Random rand = new Random();
int index = rand.Next(destinations.Length);



Console.WriteLine("Hello, Welcome to Your Random Day Trip Generator! Please Choose a Destination!");
Console.WriteLine($"Your First Random Destination Chosen for you is {destinations[index]}, Do You Like This Place?(Y/N)");
string inputChoice = Console.ReadLine();
Console.WriteLine($"You Chose {inputChoice}!");
if (inputChoice == "Y")
{
    Console.WriteLine("Lets See What Snacks They Have While Your There!");
} else 
{
   Console.WriteLine($"How About {destinations[index]}?");
}