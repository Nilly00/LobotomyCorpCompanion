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

using System.Runtime.CompilerServices;

struct AbnormalitySave(bool unlocked, Department department, int researchLevel)
{
    internal bool unlocked = unlocked;
    internal Department department = department;
    internal int researchLevel = researchLevel;
}

internal class EmployeeSave
{
    public string name;
    public PrimaryStats primaryStats;
    public string primaryTitle;
    public string secondaryTitle;
    public string department;
    public int daysInService;
    public string weapon;
    public string suit;
    public string[] gifts;

    public Employee ToProper()
    {
        EgoGift[] giftArray = new EgoGift[14];
        foreach (string gift in gifts)
        {
            {
                EgoGift current = GiftManagement.GetByName(gift);
                giftArray[(int)current.slot] = current;
            }
        }

        Employee converted = new(
            name: name,
            primaryLevels: primaryStats,
            primaryTitle: primaryTitle,
            secondaryTitle: secondaryTitle,
            department:     DepartmentManagement.GetByName(department),
            daysInService: daysInService,
            weapon: WeaponManagement.GetByName(weapon),
            suit: SuitManagement.GetByName(suit),
            gifts: giftArray
            );

        return converted;
    }

    public EmployeeSave(Employee employee)
    {
        name = employee.name;
        primaryStats = employee.PrimaryStats;
        primaryTitle = employee.PrimaryTitle;
        secondaryTitle = employee.SecondaryTitle;
        department = employee.Department.name;
        daysInService = employee.DaysInService;


    }
}
internal static class SaveManagament
{
    internal static string savePath = "";
    internal static Dictionary<string, AbnormalitySave> abnoSave = [];

    internal static void Save()
    {
        SaveAbnormalities();
    }

    internal static void SaveAbnormalities()
    {
        //todo
    }
}