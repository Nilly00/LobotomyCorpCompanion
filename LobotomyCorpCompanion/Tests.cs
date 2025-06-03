
using System.Security.Cryptography;

namespace LobotomyCorpCompanion
{
    internal static class RandomHelper
    {
        internal static Random random = new();
        private static readonly List<string> Names =
            [
            "Acacia","Adam","Alex","Alisa","Anastasia","Angel","Angelina","Anthony","Anton","Ara","Arang","Archer","Asera","Ashely",
            "Aurora","Basil","Bella","Bong-Bong","Brook","Brown","Camille","Cedric","Charlotte","Christopher","Cloie","Cooper",
            "Corbinian","Courtney","Dakota","Dana","Daniel","Daphne","Delaney","Delilah","Destiny","Devona","Dexter","Dia","Diva","BongBong"
            ];


        public static String Primary()
        {
            return Employee.PrimaryTitles.ElementAt(random.Next(Employee.PrimaryTitles.Count)).Key;
        }
        public static String Secondary()
        {
            return Employee.SecondaryTitles.ElementAt(random.Next(Employee.SecondaryTitles.Count)).Key;
        }
        public static String Name()
        {
            return Names[random.Next(Names.Count)];
        }

        public static PrimaryStats PrimaryStats()
        {
            PrimaryStats stats = new(
                fortitude: random.Next(15, 100),
                prudence: random.Next(15, 100),
                temperance: random.Next(15, 100),
                justice: random.Next(15, 100)
            );

            return stats;
        }
    }
    internal static class Tests
    {
        //employee without gifts
        public static Employee MockEmployee()
        {
            Employee BongBong = new()
            {
                Department = Control.Instance
            };
            return BongBong;
        }

        //employee with all gift slots filled
        public static Employee FullyGiftedEmployee()
        {
            Employee BongBong = new()
            {
                Department = Control.Instance
            };

            BongBong.AddGift(Apple_Gift.Instance);
            BongBong.AddGift(Despair_Gift.Instance);
            BongBong.AddGift(Censored_Gift.Instance);
            BongBong.AddGift(Wolf_Gift.Instance);
            BongBong.AddGift(Greed_Gift.Instance);
            BongBong.AddGift(Bloodbath_Gift.Instance);
            BongBong.AddGift(Bear_Gift.Instance);
            BongBong.AddGift(Army_Gift.Instance);
            BongBong.AddGift(White_Gift.Instance);
            BongBong.AddGift(Apocalypse_Gift.Instance);
            BongBong.AddGift(Forsaken_Gift.Instance);
            BongBong.AddGift(Current_Gift.Instance);
            BongBong.AddGift(Galaxy_Gift.Instance);
            BongBong.AddGift(Plague_Gift.Instance);

            BongBong.Calculate();

            return BongBong;
        }

        //randomly kitted employee
        public static Employee RandomTest()
        {
            Random random = new();

            Employee employee = new(
                name: RandomHelper.Name(),
                primaryLevels: RandomHelper.PrimaryStats(),
                primaryTitle: RandomHelper.Primary(),
                secondaryTitle: RandomHelper.Secondary(),
                department: DepartmentManagement.GetRandom(),
                daysInService: random.Next(1, 100),
                weapon: WeaponManagement.GetRandom(),
                suit: SuitManagement.GetRandomSuit(),
                gifts: GiftManagement.RandomGiftSet()
            );

            return employee;
        }
        
        //set functionality test
        public static Employee SetTest()
        {
            Employee employee = MockEmployee();
            employee.AddGift(Freischütz_Gift.Instance);
            employee.Weapon = Freischütz_Weapon.Instance;
            employee.Suit = Freischütz_Suit.Instance;

            return employee;
        }

        public static void SaveEmployee()
        {
            Employee BongBong = FullyGiftedEmployee();

            BongBong.Calculate();
            System.Console.WriteLine(BongBong);

            //write bongbong to file
            var serialisedResult = JsonConvert.SerializeObject(BongBong);
            File.WriteAllText(@"...\BongBong.json", serialisedResult);
        }

        public static void ReadEmployee()
        {
            string readJson = File.ReadAllText(@"...\BongBong.json");
            var loadedEmployee = JsonConvert.DeserializeObject<Employee>(readJson);
            System.Console.WriteLine(loadedEmployee);

            //todo make sure all fields are saved and loaded
        }
    }
}
