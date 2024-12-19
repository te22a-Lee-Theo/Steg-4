public class Worker
{
    protected string Name;
    protected int Age;
    protected int Wage;
    // public Worker(string name, int age)
    // {
    //     Name = name;
    //     Age = age;
    //     Wage = 0;
    // }
    public int SetWage()
    {
        while (true)
        {
            System.Console.WriteLine("Set worker wage");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out Wage);
            if (success)
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Enter a valid wage");
            }
            
        }
        return Wage;
    }
    public string GetName()
    {
        return Name;
    }
    public int GetAge()
    {
        return Age;
    }
    public int GetWage()
    {
        return Wage;
    }
}
