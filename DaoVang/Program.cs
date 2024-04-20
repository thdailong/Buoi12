namespace DaoVang;
class Program
{

    public static int CalculateGold(int ore)
    {
        try
        {
            if (ore < 0)
            {
                throw new ArgumentException("Number of ore cannot be negative");
            }
            int firstTenOre = Math.Min(ore, 10);
            int nextFiveOre = Math.Min(ore, 5);
            int nextThreeOre = Math.Min(ore, 3);
            int remainingOre = (ore - firstTenOre - nextFiveOre - nextThreeOre);
            int totalGold = firstTenOre * 10 + nextFiveOre * 5 + nextThreeOre * 2 + remainingOre;
            Console.WriteLine("Number of gold you will get: " + totalGold);
            return totalGold;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            return 0;
        }

    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of gold: ");
        int ore = Convert.ToInt32(Console.ReadLine());
        CalculateGold(ore);
    }
}
