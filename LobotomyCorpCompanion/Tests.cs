
using System.Security.Cryptography;

namespace LobotomyCorpCompanion
{
    internal static class RandomHelper
    {
        internal static Random random = new();
        private static List<string> Names =
            [
            "Acacia","Adam","Alex","Alisa","Anastasia","Angel","Angelina","Anthony","Anton","Ara","Arang","Archer","Asera","Ashely",
            "Aurora","Basil","Bella","Bong-Bong","Brook","Brown","Camille","Cedric","Charlotte","Christopher","Cloie","Cooper",
            "Corbinian","Courtney","Dakota","Dana","Daniel","Daphne","Delaney","Delilah","Destiny","Devona","Dexter","Dia","Diva","BongBong"
            ];


        public static String Primary()
        {
            return Employee.primaryTitles.ElementAt(random.Next(Employee.primaryTitles.Count)).Key;
        }
        public static String Secondary()
        {
            return Employee.secondaryTitles.ElementAt(random.Next(Employee.secondaryTitles.Count)).Key;
        }
        public static Department Depart()
        {
            return Department.list.Values.ElementAt(random.Next(Department.list.Count));
        }
        public static String Name()
        {
            return Names[random.Next(Names.Count)];
        }
    }
    internal static class Tests
    {
        //employee without gifts
        public static void MockEmployee()
        {
            Employee BongBong = new()
            {
                department = Control.Instance
            };
            System.Console.WriteLine(BongBong);
        }

        //employee with all gift slots filled
        public static Employee FullyGiftedEmployee()
        {
            Employee BongBong = new()
            {
                department = Control.Instance
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
            List<string> Names =
            [
                "Acacia","Adam","Alex","Alisa","Anastasia","Angel","Angelina","Anthony","Anton","Ara","Arang","Archer","Asera","Ashely",
                "Aurora","Basil","Bella","Bong-Bong","Brook","Brown","Camille","Cedric","Charlotte","Christopher","Cloie","Cooper",
                "Corbinian","Courtney","Dakota","Dana","Daniel","Daphne","Delaney","Delilah","Destiny","Devona","Dexter","Dia","Diva"
            ];
            Random random = new();

            PrimaryStats primaryStats = new(
                fortitude: random.Next(15, 100),
                prudence: random.Next(15, 100),
                temperance: random.Next(15, 100),
                justice: random.Next(15, 100)
            );

            EgoGift[] gifts= new EgoGift[14];

            gifts[0] = GiftManagement.RandomGift(Slot.Brooch);
            gifts[1] = GiftManagement.RandomGift(Slot.Cheek);
            gifts[2] = GiftManagement.RandomGift(Slot.Eye);
            gifts[3] = GiftManagement.RandomGift(Slot.Face);
            gifts[4] = GiftManagement.RandomGift(Slot.Hand_1);
            gifts[5] = GiftManagement.RandomGift(Slot.Hand_2);
            gifts[6] = GiftManagement.RandomGift(Slot.Hat);
            gifts[7] = GiftManagement.RandomGift(Slot.Helmet);
            gifts[8] = GiftManagement.RandomGift(Slot.Left_back);
            gifts[9] = GiftManagement.RandomGift(Slot.Right_back);
            gifts[10] = GiftManagement.RandomGift(Slot.Mouth_1);
            gifts[11] = GiftManagement.RandomGift(Slot.Mouth_2);
            gifts[12] = GiftManagement.RandomGift(Slot.Neckwear);
            gifts[13] = GiftManagement.RandomGift(Slot.Special);


            Employee employee = new(
                name: RandomHelper.Name(),
                primaryLevels: primaryStats,
                primaryTitle: RandomHelper.Primary(),
                secondaryTitle: RandomHelper.Secondary(),
                department: RandomHelper.Depart(),
                daysInService: random.Next(1, 100),
                isCaptain: random.Next(0, 2) == 1,
                weapon: WeaponManagement.GetRandomWeapon(),
                suit: SuitManagement.GetRandomSuit(),
                gifts: gifts
            );

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
