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

using System.Diagnostics;

internal class AbnormalitySave(Abnormality abnormality)
{
    internal bool Unlocked { get; set; } = abnormality.Unlocked;
    internal string Department { get; set; } = abnormality.Department.Name;
    internal int ResearchLevel { get; set; } = abnormality.ResearchLevel;
}

internal class EmployeeSave
{
    public string Name { get; set; }
    public PrimaryStats PrimaryStats { get; set; }
    public string PrimaryTitle { get; set; }
    public string SecondaryTitle { get; set; }
    public string Department { get; set; }
    public int DaysInService { get; set; }
    public string Weapon { get; set; }
    public string Suit { get; set; }
    public List<string> Gifts { get; set; }

    public EmployeeSave(Employee employee)
    {
        
        Name = employee.Name;
        PrimaryStats = employee.PrimaryStats;
        PrimaryTitle = employee.PrimaryTitle;
        SecondaryTitle = employee.SecondaryTitle;
        Department = employee.Department.Name;
        DaysInService = employee.DaysInService;
        Weapon = employee.Weapon.Name;
        Suit = employee.Suit.Name;
        Gifts = [];
        if (employee.Gifts[0] != null) {
            foreach (EgoGift gift in employee.Gifts)
            {
                Gifts.Add(gift.Name);
            }
        }
    }

    //parameterless constructor for deserialisation
    public EmployeeSave() { }

    public override string ToString()
    {
        string formatted;
        formatted =
            "Name: " + Name +
            "\n" + PrimaryTitle + SecondaryTitle +
            "\n" + Department +
            "\n" + PrimaryStats.ToString() +
            "\nDays in Service: " + DaysInService +
            "\nWeapon: " + Weapon + " | Suit: " + Suit +
            "\nGifts:";
        if (Gifts.Count > 0)
        {
            foreach (string gift in Gifts) { formatted += "\n" + gift; }
        }
        return formatted;
    }
}
internal static class SaveManagement
{
    internal static string savePath=""; 
    internal static Dictionary<string,AbnormalitySave> AbnSav { get; set; } = [];
    internal static List<EmployeeSave> EmpSav { get; set; } = [];

    public static void Load()
    {
        savePath = Path.Join(AppContext.BaseDirectory, "Saves");
        if (!Path.Exists(savePath))
        {
            Directory.CreateDirectory(savePath);
        }
        else
        {
            if (Path.Exists(Path.Join(savePath, "Abnormalities.json")))
            {
                //read save file
                AbnSav = JsonSerializer.Deserialize<Dictionary<string,AbnormalitySave>>(Path.Join(savePath, "Abnormalities.json"));


                //register saved values
                AbnormalitySave save;
                Abnormality abnormality;
                foreach (KeyValuePair<string, AbnormalitySave> entry in AbnSav)
                {
                    save = entry.Value;
                    abnormality = AbnormalityManager.GetByName(entry.Key);
                    abnormality.Unlocked = save.Unlocked;
                    abnormality.ResearchLevel = save.ResearchLevel;
                    abnormality.MoveToDepartment(DepartmentManager.GetByName(save.Department));
                }
            }

            if (Path.Exists(Path.Join(savePath, "Employees.json")))
            {
                //read save file
                EmpSav = JsonSerializer.Deserialize<List<EmployeeSave>>(Path.Join(savePath, "Employees.json"));
                Debug.Assert(EmpSav != null);
                //create employees which will automatically be assigned to their department
                if (EmpSav.Count !=0 )
                {
                    foreach (EmployeeSave save in EmpSav)
                    {
                        new Employee(save);
                    }
                }
            }
        }
    }
    internal static void SaveAll()
    {
        SaveAbnormalities();
        SaveEmployees();
    }

    internal static void SaveAbnormalities()
    {
        AbnSav.Clear();
        foreach(Abnormality abnormality in AbnormalityManager.MasterList)
        {
            AbnSav.Add(abnormality.Name,new AbnormalitySave(abnormality));
        }
        File.WriteAllText(Path.Join(savePath, "Abnormalities.json"), JsonSerializer.Serialize(AbnSav));
    }

    internal static void SaveEmployees()
    {
        EmpSav.Clear();
        foreach (Department department in DepartmentManager.MasterList)
        {
            if (department.Employees.Count != 0)
            {
                foreach (Employee employee in department.Employees)
                {
                    EmpSav.Add(new EmployeeSave(employee));
                }
            }
        }
        File.WriteAllText(Path.Join(savePath,"Employees.json"), JsonSerializer.Serialize(EmpSav));
    }
}