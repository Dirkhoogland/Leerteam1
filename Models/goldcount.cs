class Gold 
{
    public int goldCount = 0;
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

public class Goblin : Monster
{
    public Goblin()
    {
        Name = "Goblin";
        MinGold = 10;
        MaxGold = 20;
    }
}

public class Dragon : Monster
{
    public Dragon()
    {
        Name = "Dragon";
        MinGold = 100;
        MaxGold = 200;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Goblin goblin = new Goblin();
        Dragon dragon = new Dragon();

        Console.WriteLine($"You've defeated a {goblin.Name} and received {goblin.Defeat()} gold!");
        Console.WriteLine($"You've defeated a {dragon.Name} and received {dragon.Defeat()} gold!");
    }
}


