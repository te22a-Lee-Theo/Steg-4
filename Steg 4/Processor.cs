public class Processor: Hardware
{
    public int CoreAmount;
    public int ClockSpeed;
    public Processor(string name, int price, int coreamount, int clockspeed)
    {
        Name = name;
        Price = price;
        CoreAmount = coreamount;
        ClockSpeed = clockspeed;

    }
}
