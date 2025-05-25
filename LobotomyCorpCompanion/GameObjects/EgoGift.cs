namespace LobotomyCorpCompanion.GameObjects
{

    enum Slot
    {
        Brooch = 0,
        Cheek = 1,
        Eye = 2,
        Face = 3,
        Hand_1 = 4,
        Hand_2 = 5,
        Hat = 6,
        Helmet = 7,
        Left_back = 8,
        Right_back = 9,
        Mouth_1 = 10,
        Mouth_2 = 11,
        Neckwear = 12,
        Special = 13,
    }

    internal static class GiftManagement
    {
        internal static List<EgoGift> GetList(Slot type)
        {
            switch ((int)type)
            {
                case 0:
                    return EgoGift_Brooch.List.Cast<EgoGift>().ToList();
                case 1:
                    return EgoGift_Cheek.List.Cast<EgoGift>().ToList();
                case 2:
                    return EgoGift_Eye.List.Cast<EgoGift>().ToList();
                case 3:
                    return EgoGift_Face.List.Cast<EgoGift>().ToList();
                case 4:
                    return EgoGift_Hand_1.List.Cast<EgoGift>().ToList();
                case 5:
                    return EgoGift_Hand_2.List.Cast<EgoGift>().ToList();
                case 6:
                    return EgoGift_Hat.List.Cast<EgoGift>().ToList();
                case 7:
                    return EgoGift_Helmet.List.Cast<EgoGift>().ToList();
                case 8:
                    return EgoGift_Left_Back.List.Cast<EgoGift>().ToList();
                case 9:
                    return EgoGift_Right_Back.List.Cast<EgoGift>().ToList();
                case 10:
                    return EgoGift_Mouth_1.List.Cast<EgoGift>().ToList();
                case 11:
                    return EgoGift_Mouth_2.List.Cast<EgoGift>().ToList();
                case 12:
                    return EgoGift_Neckwear.List.Cast<EgoGift>().ToList();
                case 13:
                    return EgoGift_Special.List.Cast<EgoGift>().ToList();
                default:
                    throw new ArgumentException($"Unknown type: {type}");
            }
        }
        internal static List<EgoGift> GetList(string type)
        {
            switch (type)
            {
                case "Brooch":
                    return EgoGift_Brooch.List.Cast<EgoGift>().ToList();
                case "Cheek":
                    return EgoGift_Cheek.List.Cast<EgoGift>().ToList();
                case "Eye":
                    return EgoGift_Eye.List.Cast<EgoGift>().ToList();
                case "Face":
                    return EgoGift_Face.List.Cast<EgoGift>().ToList();
                case "Hand_1":
                    return EgoGift_Hand_1.List.Cast<EgoGift>().ToList();
                case "Hand_2":
                    return EgoGift_Hand_2.List.Cast<EgoGift>().ToList();
                case "Hat":
                    return EgoGift_Hat.List.Cast<EgoGift>().ToList();
                case "Helmet":
                    return EgoGift_Helmet.List.Cast<EgoGift>().ToList();
                case "Left_back":
                    return EgoGift_Left_Back.List.Cast<EgoGift>().ToList();
                case "Right_back":
                    return EgoGift_Right_Back.List.Cast<EgoGift>().ToList();
                case "Mouth_1":
                    return EgoGift_Mouth_1.List.Cast<EgoGift>().ToList();
                case "Mouth_2":
                    return EgoGift_Mouth_2.List.Cast<EgoGift>().ToList();
                case "Neckwear":
                    return EgoGift_Neckwear.List.Cast<EgoGift>().ToList();
                case "Special":
                    return EgoGift_Special.List.Cast<EgoGift>().ToList();
                default:
                    throw new ArgumentException($"Unknown type: {type}");
            }
        }
    }
    internal abstract class EgoGift
    {

        internal readonly Abnormality origin;
        internal readonly string name;
        internal readonly SecondaryStats secondaryStats; //HP,SP,WR,WS,AS,MS
        internal readonly short unlockLevel;

        protected EgoGift(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel)
        {
            this.origin = origin;
            this.name = name;
            this.secondaryStats = secondaryStats;
            this.unlockLevel = unlockLevel;
        }

        internal virtual void Add(Employee employee) {}
        internal virtual void Effect(Employee employee) { }
    }
    internal abstract class EgoGift_Brooch : EgoGift
    {
        internal static List<EgoGift_Brooch> List = new List<EgoGift_Brooch>{
            Apple_Gift.Instance,
            Fragments_Gift.Instance,
            Luna_Gift.Instance,
            MHZ_Gift.Instance,
            Woodsman_Gift.Instance,
        };

        protected EgoGift_Brooch(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[0] = this;
        }
    }
    internal abstract class EgoGift_Cheek : EgoGift
    {
        internal readonly static List<EgoGift_Cheek> List = new List<EgoGift_Cheek>
        {
            Despair_Gift.Instance,
            Nothing_Gift.Instance,
            Snow_Gift.Instance,
            Singing_Gift.Instance,
        };

        protected EgoGift_Cheek(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[1] = this;
        }
    }
    internal abstract class EgoGift_Eye : EgoGift
    {
        internal readonly static List<EgoGift_Eye> List = new List<EgoGift_Eye>
        {
            Censored_Gift.Instance,
            Helper_Gift.Instance,
            OldLady_Gift.Instance,
            Orchestra_Gift.Instance,
            Shy_Gift.Instance,
            Smiling_Gift.Instance,
            Spider_Gift.Instance,
            Star_Gift.Instance,
        };

        protected EgoGift_Eye(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[2] = this;
        }
    }
    internal abstract class EgoGift_Face : EgoGift
    {
        internal readonly static List<EgoGift_Face> List = new List<EgoGift_Face>
        {
            Wolf_Gift.Instance,
        };
        protected EgoGift_Face(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[3] = this;
        }
    }
    internal abstract class EgoGift_Hand_1 : EgoGift
    {
        internal readonly static List<EgoGift_Hand_1> List = new List<EgoGift_Hand_1>
        {
            Greed_Gift.Instance,
            Monk_Gift.Instance,
        };
        protected EgoGift_Hand_1(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[4] = this;
        }
    }
    internal abstract class EgoGift_Hand_2 : EgoGift
    {
        internal readonly static List<EgoGift_Hand_2> List = new List<EgoGift_Hand_2>
        {
            Bloodbath_Gift.Instance,
            Fairy_Gift.Instance,
            Nest_Gift.Instance,
            Prince_Gift.Instance,
            Schadenfreude_Gift.Instance,
        };
        protected EgoGift_Hand_2(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[5] = this;
        }
    }
    internal abstract class EgoGift_Hat : EgoGift
    {
        internal readonly static List<EgoGift_Hat> List = new List<EgoGift_Hat>
        {
            Bear_Gift.Instance,
            Beauty_Gift.Instance,
            Bee_Gift.Instance,
            Cherry_Gift.Instance,
            Crumbling_Gift.Instance,
            Crumbling_B_Gift.Instance,
            Crumbling_O_Gift.Instance,
            Crumbling_R_Gift.Instance,
            Cute_Gift.Instance,
            Dream_Gift.Instance,
            Firebird_Gift.Instance,
            Hatred_Gift.Instance,
            OneSin_Gift.Instance,
            Rabbit_Gift.Instance,
            Rudolta_Gift.Instance,
            Sheep_Gift.Instance,
        };
        protected EgoGift_Hat(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[6] = this;
        }
    }
    internal abstract class EgoGift_Helmet : EgoGift
    {
        internal readonly static List<EgoGift_Helmet> List = new List<EgoGift_Helmet>
        {
            Army_Gift.Instance,
            Big_Gift.Instance,
            Fetus_Gift.Instance,
            Heaven_Gift.Instance,
            Laetitia_Gift.Instance,
            Love_Gift.Instance,
            Parasite_Gift.Instance,
            Refraction_Gift.Instance,
            Yin_Gift.Instance,
        };
        protected EgoGift_Helmet(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[7] = this;
        }
    }
    internal abstract class EgoGift_Left_Back : EgoGift
    {
        internal readonly static List<EgoGift_Left_Back> List = new List<EgoGift_Left_Back>
        {
            White_Gift.Instance,
        };
        protected EgoGift_Left_Back(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[8] = this;
        }
    }
    internal abstract class EgoGift_Right_Back : EgoGift
    {
        internal readonly static List<EgoGift_Right_Back> List = new List<EgoGift_Right_Back>
        {
            Apocalypse_Gift.Instance,
            Butterflies_Gift.Instance,
        };
        protected EgoGift_Right_Back(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[9] = this;
        }
    }
    internal abstract class EgoGift_Mouth_1 : EgoGift
    {
        internal readonly static List<EgoGift_Mouth_1> List = new List<EgoGift_Mouth_1>
        {
            Forsaken_Gift.Instance,
            Ridinghood_Gift.Instance,
        };
        protected EgoGift_Mouth_1(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[10] = this;
        }
    }
    internal abstract class EgoGift_Mouth_2 : EgoGift
    {
        internal readonly static List<EgoGift_Mouth_2> List = new List<EgoGift_Mouth_2>
        {
            Current_Gift.Instance,
            Freischütz_Gift.Instance,
            Lantern_Gift.Instance,
            Scorched_Gift.Instance,
            Shoes_Gift.Instance,
            Wellcheers_Gift.Instance,
        };
        protected EgoGift_Mouth_2(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[11] = this;
        }
    }
    internal abstract class EgoGift_Neckwear : EgoGift
    {
        internal readonly static List<EgoGift_Neckwear> List = new List<EgoGift_Neckwear>
        {
            Galaxy_Gift.Instance,
            Porccubus_Gift.Instance,
            Punishing_Gift.Instance,
        };
        protected EgoGift_Neckwear(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[12] = this;
        }
    }
    internal abstract class EgoGift_Special : EgoGift
    {
        internal readonly static List<EgoGift_Special> List = new List<EgoGift_Special>
        {
            Plague_Gift.Instance,
        };
        protected EgoGift_Special(Abnormality origin, string name, SecondaryStats secondaryStats, short unlockLevel) : base(origin, name, secondaryStats, unlockLevel) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[13] = this;
        }
    }
}
