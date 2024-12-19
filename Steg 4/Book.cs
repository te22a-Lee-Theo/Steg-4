public class Book
{
    private string Name;
    private int Pages;
    private int CurrentPage = 0;

    public Book(string name, int pages)
    {
        Name = name;
        Pages = pages;
    }

    public void TurnPage()
    {
        CurrentPage++;
    }
    public int GetCurrentPage()
    {
        return CurrentPage;
    }
    public string GetName()
    {
        return Name;
    }
    public int GetPages()
    {
        return Pages;
    }
}
