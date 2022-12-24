// See https://aka.ms/new-console-template for more information

//Destinations Array
string[] destinations = {"Reptar World", "Glove World", "Atlantis", "Inner Earth"};

Random rand = new Random();
int index = rand.Next(destinations.Length);



Console.WriteLine("Hello, Welcome to Your Random Day Trip Generator! Please Choose a Destination!");
Console.WriteLine($"Your First Random Destination Chosen for you is {destinations[index]}, Do You Like This Place?(Yes/No)");
string inputChoice = Console.ReadLine();
Console.WriteLine($"You Chose {inputChoice}!");
switch(inputChoice) 
{
  case "Yes":
    Console.WriteLine("Great Choice! Lets See What Options We Have For Transportation!");
    break;
  case "No":
    Random randTwo = new Random();
    int index2 = rand.Next(destinations.Length);
    Console.WriteLine($"Your Next Choice is {destinations[index2]}, Good Choice? (Yes/No)");
    string inputChoice2 = Console.ReadLine();
    Console.WriteLine($"You chose {inputChoice2}");
    if(inputChoice2 == "Yes")
    {
        Console.WriteLine("You Choose The Best Spot! Lets See What Means of Travel You Have To Get There! ");
    } else if (inputChoice2 == "No")
    {
        Random randThree = new Random();
        int index3 = rand.Next(destinations.Length);
        Console.WriteLine($"Your Next Option Is: {destinations[index3]}, Is This Your Choice?");
        string inputChoice3 = Console.ReadLine();
        Console.WriteLine($"You Chose {inputChoice3}!");
        if (inputChoice3 == "Yes")
        {
            Console.WriteLine("Great Lets Move Along!");
        } else
        {
            Console.WriteLine("I have No Other Options :( , Lets Start Over!");
        }

    } else
    {
        Console.WriteLine("Thats not a choice! Try Again!");
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
Console.WriteLine($"Now That we Have our Destination, How Are You Getting There? How About {transportation[index]}? (Yes/No)");
string inputChoice4 = Console.ReadLine();
Console.WriteLine($"You Chose {inputChoice4}");
switch(inputChoice4)
{
  case "Yes":
    Console.WriteLine("Great Choice! Lets See What Options We Have For Food!");
    break;
  case "No":
    Random randFive = new Random();
    int index5 = rand.Next(transportation.Length);
    Console.WriteLine($"Your Next Choice is {transportation[index5]}, Good Choice? (Yes/No)");
    string inputChoice5 = Console.ReadLine();
    Console.WriteLine($"You chose {inputChoice5}");
    if(inputChoice5 == "Yes")
    {
        Console.WriteLine("What A Great Choice! Lets See What Food You Have There! ");
    } else if (inputChoice5 == "No")
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
        Console.WriteLine("Thats not a choice! Try Again!");
    }
    break;
  default:
    Console.WriteLine("Thats not a choice! Try Again!");
    break;
}

//Add Food Array and Choices starting with inputChoice7, randSeven and index7
string[] food = {"Pasta", "Seafood", "CornDogs", "Elephant Ears"};
Random randSeven = new Random();
int index7 = rand.Next(food.Length);
Console.WriteLine($"Now That we Have our Destination and How You'll Get there, You're Going To Get Hungry During All This! Whats Your Pick? {food[index]}?");
string inputChoice7 = Console.ReadLine();
Console.WriteLine($"You Chose {inputChoice7}!");
switch(inputChoice7)
{
  case "Yes":
    Console.WriteLine("Great Choice! Lets See What Events Are Planned For The Night!");
    break;
  case "No":
    Random randEight = new Random();
    int index8 = rand.Next(food.Length);
    Console.WriteLine($"Your Next Choice is {food[index8]}, Good Choice? (Yes/No)");
    string inputChoice8 = Console.ReadLine();
    Console.WriteLine($"You chose {inputChoice8}");
    if(inputChoice8 == "Yes")
    {
        Console.WriteLine("A Delicious Choice! Lets See What Events Are Planned For The Night! ");
    } else if (inputChoice8 == "No")
    {
        Random randNine = new Random();
        int index9 = rand.Next(food.Length);
        Console.WriteLine($"Your Next Option Is: {food[index9]}, Is This Your Choice?");
        string inputChoice9 = Console.ReadLine();
        Console.WriteLine($"You Chose {inputChoice9}!");
        if (inputChoice9 == "Y")
        {
            Console.WriteLine("Great Lets Move Along!");
        } else
        {
            Console.WriteLine("I have No Other Options :( , Lets Start Over!");
        }

    } else
    {
        Console.WriteLine("Thats not a choice! Try Again!");
    }
    break;
  default:
    Console.WriteLine("Thats not a choice! Try Again!");
    break;
}

//Events Array and Choice Loops
string[] events = {"Music Concert", "Opera", "Synchronize Swimmers", "Balloon Festival"};
