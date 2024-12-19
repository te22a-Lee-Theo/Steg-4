//  Book one = new(
//     "Backstabbed in a Backwater Dungeon: My Trusted Companions Tried to Kill Me, but Thanks to the Gift of an Unlimited Gacha I Got LVL 9999 Friends and Am Out for Revenge on My Former Party Members and the World",
//     200
//  );
//  Book two = new(
//    "As a Reincarnated Aristocrat, I'll Use My Appraisal Skill to Rise in the World: I Inherited a Weak Territory, and If I Increase the Number of Capable Personnel, It Will Become the Strongest Territory.",
//    150
//  );
//  Book three = new(
//    "my instant death ability is so overpowered no one in this other world stands a chance aganist me",
//    500
//  );


// three.TurnPage();
// int ThreeP = three.GetPages();
// string ThreeN = three.GetName();
// System.Console.WriteLine(ThreeP);
// System.Console.WriteLine(ThreeN);

// System.Console.WriteLine("How many rock do you want to create?");
// string Num = Console.ReadLine();
// int Amount;
// bool success = int.TryParse(Num, out Amount);

// for (int i = 0; i < Amount; i++)
// {
//    System.Console.WriteLine("Enter a weight for the rock");
//    string input = Console.ReadLine();
//    int Vikt;
//    success = int.TryParse(input, out Vikt);
//    Rock First = new(Vikt);
//    Rock.Rocks.Add(First);
// }

// Worker First = new Whitecollar("Anders", 50);
// Worker Second = new BlueCollar("Teodora", 20);

// int SecondA = Second.GetAge();
// string SecondN = Second.GetName();
// Second.SetWage();
// int SecondW = Second.GetWage();

// System.Console.WriteLine(SecondA);
// System.Console.WriteLine(SecondN);
// System.Console.WriteLine(SecondW);

// int FirstA = First.GetAge();
// string FirstN = First.GetName();
// First.SetWage();
// int FirstW = Second.GetWage();

// System.Console.WriteLine(FirstA);
// System.Console.WriteLine(FirstN);
// System.Console.WriteLine(FirstW);


System.Console.WriteLine("Vill du skapa en Processor, en Harddrive eller ett Graphics Card");
String ans = Console.ReadLine();
if (ans == "p")
{
   Hardware First = new Processor("Processor", 1200, 4, 500);
   Hardware.Hardwares.Add(First);
}
else if (ans == "h")
{
   Hardware Second = new Harddrive("Harddrive", 500, 256);
   Hardware.Hardwares.Add(Second);
}
else if (ans == "g")
{
   Hardware Third = new Graphicscard("Graphics Card", 5000, 8, 500);
   Hardware.Hardwares.Add(Third);
}

Hardware.DisplayList();


Console.ReadLine();