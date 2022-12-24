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
    Console.WriteLine("Great Choice! Lets See What Options We Have For Transportation!");
    break;
  case "N":
    Random randTwo = new Random();
    int index2 = rand.Next(destinations.Length);
    Console.WriteLine($"Your Next Choice is {destinations[index2]}, Good Choice? (Y/N)");
    string inputChoice2 = Console.ReadLine();
    Console.WriteLine($"You chose {inputChoice2}");
    if(inputChoice2 == "Y")
    {
        Console.WriteLine("You Choose The Best Spot! Lets See What Means of Travel You Have To Get There! ");
    } else if (inputChoice2 == "N")
    {
        Random randThree = new Random();
        int index3 = rand.Next(destinations.Length);
        Console.WriteLine($"Your Next Option Is: {destinations[index3]}, Is This Your Choice?");
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

//Transportation Array And Choice List
string[] transportation = {"VW Retro Bus", "Private Jet", "Moped/Motorcycle", "Ferry"};



Random randFour = new Random();
int index4 = rand.Next(transportation.Length);
Console.WriteLine($"Now That we Have our Destination, How Are You Getting There? How About {transportation[index]}? (Y/N)");
string inputChoice4 = Console.ReadLine();
Console.WriteLine($"You Chose {inputChoice4}");
switch(inputChoice4)
{
  case "Y":
    Console.WriteLine("Great Choice! Lets See What Options We Have For Food!");
    break;
  case "N":
    Random randFive = new Random();
    int index5 = rand.Next(transportation.Length);
    Console.WriteLine($"Your Next Choice is {transportation[index5]}, Good Choice? (Y/N)");
    string inputChoice5 = Console.ReadLine();
    Console.WriteLine($"You chose {inputChoice5}");
    if(inputChoice5 == "Y")
    {
        Console.WriteLine("You Choose The Best Spot! Lets See What Food You Have There! ");
    } else if (inputChoice5 == "N")
    {
        Random randSix = new Random();
        int index6 = rand.Next(transportation.Length);
        Console.WriteLine($"Your Next Option Is: {transportation[index6]}, Is This Your Choice?");
        string inputChoice6 = Console.ReadLine();
        Console.WriteLine($"You Chose {inputChoice6}!");
        if (inputChoice6 == "Y")
        {
            Console.WriteLine("Great Lets Move Along!");
        } else
        {
            Console.WriteLine("I have No Other Options :( , Lets Start Over!");
        }

    } else
    {
        Console.WriteLine($"Your Last Option Is: {transportation[index]}");
    }
    break;
  default:
    Console.WriteLine("Thats not a choice! Try Again!");
    break;
}

