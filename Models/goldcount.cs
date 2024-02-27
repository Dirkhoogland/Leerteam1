public class Gold 
{
    public static int goldCount = 0;
    public void AddGold(int amount)
    {
        goldCount += amount;
    }
    public void SpendGold(int amount)
    {
        goldCount -= amount;
    }
    public void DisplayGold()
    {
        Console.WriteLine("The gold that you received from monster is" + goldCount);
    }
}
public class Monster
{
    protected Random random = new Random();
    public string Name { get; set; }
    public int MinGold { get; set; }
    public int MaxGold { get; set; }

    public int Defeat()
    {
        return random.Next(MinGold, MaxGold);
    }
}

public class Rat : Monster
{
    public Rat()
    {
        Name = "Rat";
        MinGold = 10;
        MaxGold = 20;
    }
}

public class Snake : Monster
{
    public Snake()
    {
        Name = "Snake";
        MinGold = 100;
        MaxGold = 200;
    }
}

public class GiantSpider : Monster
{
    public GiantSpider()
    {
        Name = "Giant Spider";
        MinGold = 100;
        MaxGold = 200;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rat rat = new Rat();
        Snake snake = new Snake();
        GiantSpider giantSpider = new GiantSpider();

        Console.WriteLine($"You've defeated a {rat.Name} and received {rat.Defeat()} gold!");
        Console.WriteLine($"You've defeated a {snake.Name} and received {snake.Defeat()} gold!");
        Console.WriteLine($"You've defeated a {giantSpider.Name} and received {giantSpider.Defeat()} gold!");
    }
}