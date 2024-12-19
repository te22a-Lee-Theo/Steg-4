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


System.Console.WriteLine("How many rock do you want to create?");
string Num = Console.ReadLine();
int Amount;
bool success = int.TryParse(Num, out Amount);

for (int i = 0; i < Amount; i++)
{
   System.Console.WriteLine("Enter a weight for the rock");
   string input = Console.ReadLine();
   int Vikt;
   success = int.TryParse(input, out Vikt);
   Rock First = new(Vikt);
   Rock.Rocks.Add(First);
}



Console.ReadLine();