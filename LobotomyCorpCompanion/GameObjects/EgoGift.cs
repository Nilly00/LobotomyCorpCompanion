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
    internal abstract class EgoGift
    {
        internal readonly Abnormality origin;
        internal readonly string name;
        internal readonly SecondaryStats secondaryStats; //HP,SP,WR,WS,AS,MS

        internal virtual void Add(Employee employee) { }

        internal virtual void Effect(Employee employee) { }


        protected EgoGift(Abnormality origin, string name, SecondaryStats secondaryStats)
        {
            this.origin = origin;
            this.name = name;
            this.secondaryStats = secondaryStats;
        }
    }
    
    internal abstract class EgoGift_Brooch : EgoGift
    {
        internal readonly static List<EgoGift_Brooch> List = new List<EgoGift_Brooch>{
            Apple_Gift.Instance,
            Fragments_Gift.Instance,
            Luna_Gift.Instance,
            MHZ_Gift.Instance,
            Woodsman_Gift.Instance,
        };

        protected EgoGift_Brooch(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
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

        protected EgoGift_Cheek(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[1] = this;
        }
    }
    internal abstract class EgoGift_Eye : EgoGift
    {
        internal readonly static List<EgoGift_Eye> List = new List<EgoGift_Eye>
        {

        };

        protected EgoGift_Eye(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[2] = this;
        }
    }
    internal abstract class EgoGift_Face : EgoGift
    {
        internal readonly static List<EgoGift_Face> List = new List<EgoGift_Face>
        {
        };
        protected EgoGift_Face(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[3] = this;
        }
    }
    internal abstract class EgoGift_Hand_1 : EgoGift
    {
        internal readonly static List<EgoGift_Hand_1> List = new List<EgoGift_Hand_1>
        {
        };
        protected EgoGift_Hand_1(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[4] = this;
        }
    }
    internal abstract class EgoGift_Hand_2 : EgoGift
    {
        internal readonly static List<EgoGift_Hand_2> List = new List<EgoGift_Hand_2>
        {
        };
        protected EgoGift_Hand_2(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[5] = this;
        }
    }
    internal abstract class EgoGift_Hat : EgoGift
    {
        internal readonly static List<EgoGift_Hat> List = new List<EgoGift_Hat>
        {
        };
        protected EgoGift_Hat(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[6] = this;
        }
    }
    internal abstract class EgoGift_Helmet : EgoGift
    {
        internal readonly static List<EgoGift_Helmet> List = new List<EgoGift_Helmet>
        {
        };
        protected EgoGift_Helmet(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[7] = this;
        }
    }
    internal abstract class EgoGift_Left_back : EgoGift
    {
        internal readonly static List<EgoGift_Left_back> List = new List<EgoGift_Left_back>
        {
        };
        protected EgoGift_Left_back(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[8] = this;
        }
    }
    internal abstract class EgoGift_Right_back : EgoGift
    {
        internal readonly static List<EgoGift_Right_back> List = new List<EgoGift_Right_back>
        {
        };
        protected EgoGift_Right_back(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[9] = this;
        }
    }
    internal abstract class EgoGift_Mouth_1 : EgoGift
    {
        internal readonly static List<EgoGift_Mouth_1> List = new List<EgoGift_Mouth_1>
        {
        };
        protected EgoGift_Mouth_1(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[10] = this;
        }
    }
    internal abstract class EgoGift_Mouth_2 : EgoGift
    {
        internal readonly static List<EgoGift_Mouth_2> List = new List<EgoGift_Mouth_2>
        {
        };
        protected EgoGift_Mouth_2(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[11] = this;
        }
    }
    internal abstract class EgoGift_Neckwear : EgoGift
    {
        internal readonly static List<EgoGift_Neckwear> List = new List<EgoGift_Neckwear>
        {
        };
        protected EgoGift_Neckwear(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[12] = this;
        }
    }
    internal abstract class EgoGift_Special : EgoGift
    {
        internal readonly static List<EgoGift_Special> List = new List<EgoGift_Special>
        {
        };
        protected EgoGift_Special(Abnormality origin, string name, SecondaryStats secondaryStats) : base(origin, name, secondaryStats) { }
        internal override void Add(Employee employee)
        {
            employee.gifts[13] = this;
        }
    }
}
