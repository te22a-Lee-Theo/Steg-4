public class Rock
{
    private int Weight;
    public Rock(int weight)
    {
        Weight = weight;
    }
    public int GetWeight()
    {
        return Weight;
    }
    public static List <Rock> Rocks = new();
}
