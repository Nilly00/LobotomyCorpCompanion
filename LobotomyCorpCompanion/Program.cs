class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        Employee employee = Tests.RandomTest();
        System.Console.WriteLine(employee);

        System.Console.WriteLine("Gifts:");
        foreach (EgoGift gift in employee.gifts)
        {
            Console.WriteLine(gift.name);
        }
    }
}