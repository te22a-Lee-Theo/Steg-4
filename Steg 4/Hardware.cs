public class Hardware
{
    public string Name;
    public int Price;
    public static List <Hardware> Hardwares = new ();

    public static void DisplayList()
    {
        for (int i = 0; i < Hardwares.Count; i++)
        {
            System.Console.WriteLine($"{Hardwares[i].Name}");
        }
    }
}
