/*
 
[JsonIgnore]
over things to be ignored

only public things will be serialised

[JsonRequired]
over things to be serialised even if they are private
 */

/*
class TestClass
{
    internal static void save(Employee employee)
    {
        // To save an object to a file:

        var serialisedResult = JsonConvert.SerializeObject(employee);
        File.WriteAllText(@"E:\File Storage\Programming stuff\C#\JsonTesting\employee.json", serialisedResult);
    }
    internal static Employee read()
    {
        // To read an object from a file:
        string readJson = File.ReadAllText(@"E:\File Storage\Programming stuff\C#\JsonTesting\employee.json");
        var loadedEmployee = JsonConvert.DeserializeObject<Employee>(readJson);
        return loadedEmployee;
    }

    static void test(string[] args)
    {
        Employee employeeSaved = new Employee();
        save(employeeSaved);

        Employee loadedEmployee = read();

        loadedEmployee.print();
    }
}
*/

struct AbnormalitySave(bool unlocked, Department department, int researchLevel)
{
    internal bool unlocked = unlocked;
    internal Department department = department;
    internal int researchLevel = researchLevel;
}
internal static class SaveManagament
{
    internal static string savePath = "";
    internal static Dictionary<string, AbnormalitySave> abnoSave = new();

    internal static void Save()
    {
        SaveAbnormalities();
    }

    internal static void SaveAbnormalities()
    {
        foreach (Abnormality abnormality in Abnormality.List)
        {
            abnoSave[abnormality.name] = new AbnormalitySave(abnormality.unlocked, abnormality.department, abnormality.researchLevel);
        }
        //todo write abnormalities to file
    }


}