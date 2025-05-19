
class Program
{
    static void Main(string[] args)
    {
        PrimaryStats stats1 = new PrimaryStats(10, 20, 30, 40);
        PrimaryStats stats2 = new PrimaryStats(1, 2, 3, 4);
        System.Console.WriteLine("stats1: " + stats1);
        System.Console.WriteLine("stats2: " + stats2);

        stats1 += stats2;

        System.Console.WriteLine("stats1 + stats2: " + stats1);

    }
}