public class Graphicscard: Hardware
{
    public int CoreAmount;
    public int ClockFrequency;
    public Graphicscard(string name, int price, int coreamount, int clockfrequency)
    {
        Name = name;
        Price = price;
        CoreAmount = coreamount;
        ClockFrequency = clockfrequency;

    }

}
