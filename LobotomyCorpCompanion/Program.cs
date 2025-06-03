class Program
{
    class TestClass
    {
        internal static void Save(Employee employee)
        {
            // To save an object to a file
            var serialisedResult = JsonConvert.SerializeObject(employee);
            File.WriteAllText(@"E:\File Storage\Programming stuff\C#\LobotomyCorpCompanion\Saves\employee.json", serialisedResult);
        }
        internal static Employee Read()
        {
            // To read an object from a file:
            string readJson = File.ReadAllText(@"E:\File Storage\Programming stuff\C#\LobotomyCorpCompanion\Saves\employee.json");
            var loadedEmployee = JsonConvert.DeserializeObject<Employee>(readJson);
            return loadedEmployee;
        }
}
static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //TestClass.Save(Tests.RandomTest());
        TestClass.Save(Tests.MockEmployee());
        System.Console.WriteLine(TestClass.Read());
    }
}