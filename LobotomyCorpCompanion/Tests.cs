


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
            return Employee.PRIMARYTITLES.ElementAt(random.Next(Employee.PRIMARYTITLES.Count)).Key;
        }
        public static String Secondary()
        {
            return Employee.SECONDARYTITLES.ElementAt(random.Next(Employee.SECONDARYTITLES.Count)).Key;
        }
        public static String Name()
        {
            return Names[random.Next(Names.Count)];
        }

        public static PrimaryStats PrimaryStats()
        {
            PrimaryStats stats = new(
                Fortitude: random.Next(15, 100),
                Prudence: random.Next(15, 100),
                Temperance: random.Next(15, 100),
                Justice: random.Next(15, 100)
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
            Random random = new Random();
            Employee employee = new(
                name: RandomHelper.Name(),
                primaryStats: RandomHelper.PrimaryStats(),
                primaryTitle: RandomHelper.Primary(),
                secondaryTitle: RandomHelper.Secondary(),
                department: DepartmentManager.GetRandom(),
                daysInService: random.Next(1, 100),
                weapon: WeaponManager.GetRandom(),
                suit: SuitManager.GetRandom(),
                gifts: GiftManager.RandomGiftSet()
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
    }
}
