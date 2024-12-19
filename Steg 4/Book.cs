public class Book
{
    public string Name;
    public int Pages;
    public int CurrentPage = 0;

    public void TurnPage()
    {
        CurrentPage++;
    }
}
