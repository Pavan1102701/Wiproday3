class Program1
{
    public int x;
    public int y;
}

class Program
{
    static void Main()
    {

          Program1 p  = new Program1();
        p.x = 10;
        p.y = 15;
        Console.WriteLine($"x = {p.x}, y = {p.y}");
    }
}
