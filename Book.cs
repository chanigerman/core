namespace core;

public class Book
{

    
    private static int _counter = 1;
   public int Id { get; } = _counter++;
   
    public string Title { get; set; }
    public string Author { get; set; }
}

