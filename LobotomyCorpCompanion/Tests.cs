using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LobotomyCorpCompanion.GameObjects;
using Newtonsoft.Json;

namespace LobotomyCorpCompanion
{
    internal static class Tests
    {
        public static void CreateEmployee()
        {
            System.Console.WriteLine("Please enter the name\n");
            string name = System.Console.ReadLine();

            System.Console.WriteLine("\nplease enter the primary title\n");
            foreach(string key in Employee.primaryTitles.Keys)
            {
                System.Console.WriteLine(key);
            }
            System.Console.WriteLine("\n");
            string primaryTitle = System.Console.ReadLine();

            System.Console.WriteLine("\nplease enter the secondary title\n");
            foreach (string key in Employee.secondaryTitles.Keys)
            {
                System.Console.WriteLine(key);
            }
            string secondaryTitle = System.Console.ReadLine();

            System.Console.WriteLine("\nPlease enter the department:\n");

            foreach (string departs in Department.list.Keys)
            {
                System.Console.WriteLine(departs);
            }
            Department department = Department.list[System.Console.ReadLine()];


            EgoWeapon weapon;
            System.Console.WriteLine("\nPlease enter the weapon:\n");
            string temp = System.Console.ReadLine();
            foreach(Abnormality abnormality in Abnormality.List)
            {
                if (abnormality.weapon != null && abnormality.weapon.name == temp)
                {
                    weapon = abnormality.weapon;
                    break;
                }
            }

            EgoSuit suit;
            System.Console.WriteLine("\nPlease enter the suit:\n");
            temp = System.Console.ReadLine();
            foreach (Abnormality abnormality in Abnormality.List)
            {
                if (abnormality.suit != null && abnormality.suit.name == temp)
                {
                    suit = abnormality.suit;
                    break;
                }
            }

            System.Console.WriteLine("");
            System.Console.ReadLine();
        }

        public static void MockEmployee()
        {
            Employee BongBong = new()
            {
                department = Control.Instance
            };
            System.Console.WriteLine(BongBong);
        }

        public static void FullyGiftedEmployee()
        {
            Employee BongBong = new()
            {
                department = Control.Instance
            };

            Apple_Gift.Instance.Add(BongBong);
            
            Despair_Gift.Instance.Add(BongBong);
            Censored_Gift.Instance.Add(BongBong);
            Wolf_Gift.Instance.Add(BongBong);
            Greed_Gift.Instance.Add(BongBong);
            Bloodbath_Gift.Instance.Add(BongBong);
            Bear_Gift.Instance.Add(BongBong);
            Army_Gift.Instance.Add(BongBong);   
            White_Gift.Instance.Add(BongBong);
            Apocalypse_Gift.Instance.Add(BongBong);
            Forsaken_Gift.Instance.Add(BongBong);
            Current_Gift.Instance.Add(BongBong);
            Galaxy_Gift.Instance.Add(BongBong);
            Plague_Gift.Instance.Add(BongBong);

            BongBong.Calculate();

            System.Console.WriteLine(BongBong);
        }
        public static void RandomTest()
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

            //todo change test to new structure
            /*
            gifts[0] = EgoGift_Brooch.List.ElementAt(random.Next(EgoGift_Brooch.List.Count));
            gifts[1] = EgoGift_Cheek.List.ElementAt(random.Next(EgoGift_Cheek.List.Count));
            gifts[2] = EgoGift_Eye.List.ElementAt(random.Next(EgoGift_Eye.List.Count));
            gifts[3] = EgoGift_Face.List.ElementAt(random.Next(EgoGift_Face.List.Count));
            gifts[4] = EgoGift_Hand_1.List.ElementAt(random.Next(EgoGift_Hand_1.List.Count));
            gifts[5] = EgoGift_Hand_2.List.ElementAt(random.Next(EgoGift_Hand_2.List.Count));
            gifts[6] = EgoGift_Hat.List.ElementAt(random.Next(EgoGift_Hat.List.Count));
            gifts[7] = EgoGift_Helmet.List.ElementAt(random.Next(EgoGift_Helmet.List.Count));
            gifts[8] = EgoGift_Left_Back.List.ElementAt(random.Next(EgoGift_Left_Back.List.Count));
            gifts[9] = EgoGift_Right_Back.List.ElementAt(random.Next(EgoGift_Right_Back.List.Count));
            gifts[10] = EgoGift_Mouth_1.List.ElementAt(random.Next(EgoGift_Mouth_1.List.Count));
            gifts[11] = EgoGift_Mouth_2.List.ElementAt(random.Next(EgoGift_Mouth_2.List.Count));
            gifts[12] = EgoGift_Neckwear.List.ElementAt(random.Next(EgoGift_Neckwear.List.Count));*/


            Employee employee = new(
                name: Names[random.Next(Names.Count)],
                primaryLevels: primaryStats,
                primaryTitle: Employee.primaryTitles.Keys.ElementAt(random.Next(Employee.primaryTitles.Count)),
                secondaryTitle: Employee.secondaryTitles.Keys.ElementAt(random.Next(Employee.secondaryTitles.Count)),
                department: Department.list.Values.ElementAt(random.Next(Department.list.Count)),
                daysInService: random.Next(1, 100),
                isCaptain: random.Next(0, 2) == 1,
                weapon: Abnormality.List.Where(a => a.weapon != null).Select(a => a.weapon).ElementAt(random.Next(Abnormality.List.Count(a => a.weapon != null))),
                suit: Abnormality.List.Where(a => a.suit != null).Select(a => a.suit).ElementAt(random.Next(Abnormality.List.Count(a => a.suit != null))),
                gifts: gifts
            );

            System.Console.WriteLine(employee);


            //todo calling the origin of a weapon/suit/gift causes a null reference exception

        }

        public static void SaveEmployee()
        {
            Employee BongBong = new()
            {
                department = Control.Instance
            };

            Apple_Gift.Instance.Add(BongBong);

            Despair_Gift.Instance.Add(BongBong);
            Censored_Gift.Instance.Add(BongBong);
            Wolf_Gift.Instance.Add(BongBong);
            Greed_Gift.Instance.Add(BongBong);
            Bloodbath_Gift.Instance.Add(BongBong);
            Bear_Gift.Instance.Add(BongBong);
            Army_Gift.Instance.Add(BongBong);
            White_Gift.Instance.Add(BongBong);
            Apocalypse_Gift.Instance.Add(BongBong);
            Forsaken_Gift.Instance.Add(BongBong);
            Current_Gift.Instance.Add(BongBong);
            Galaxy_Gift.Instance.Add(BongBong);
            Plague_Gift.Instance.Add(BongBong);

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
