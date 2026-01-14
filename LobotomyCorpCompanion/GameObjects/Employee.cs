namespace LobotomyCorpCompanion.GameObjects
{
    internal class Employee
    {
        
        internal static readonly FrozenDictionary<string, SecondaryStats> PRIMARYTITLES = new Dictionary<string, SecondaryStats>{
            {"Blunt",               new SecondaryStats(HP: 3                                            )},
            {"Indecisive",          new SecondaryStats(HP: 3,   SP:-2                                   )},
            {"Lazy",                new SecondaryStats(HP: 3,           SR:-2,  WS:-2                   )},
            {"Timid",               new SecondaryStats(HP: 3,                           AS:-2,  MS:-2   )},
            {"Amicable",            new SecondaryStats(         SP: 3                                   )},
            {"Quiet",               new SecondaryStats(HP:-2,   SP: 3                                   )},
            {"Stuffy",              new SecondaryStats(         SP: 3,  SR:-2,  WS:-2                   )},
            {"Suave",               new SecondaryStats(         SP: 3,                  AS:-2,  MS:-2   )},
            {"Honest",              new SecondaryStats(                 SR: 3,  WS: 3                   )},
            {"Earnest",             new SecondaryStats(HP:-2,           SR: 3,  WS: 3                   )},
            {"Attentive",           new SecondaryStats(         SP:-2,  SR: 3,  WS: 3                   )},
            {"Gloomy",              new SecondaryStats(                 SR: 3,  WS: 3,  AS:-2,  MS:-2   )},
            {"Bright",              new SecondaryStats(                                 AS: 3,  MS: 3   )},
            {"Frivolous",           new SecondaryStats(HP:-2,                           AS: 3,  MS: 3   )},
            {"Plucky",              new SecondaryStats(         SP:-2,                  AS: 3,  MS: 3   )},
            {"Cheery",              new SecondaryStats(                 SR:-2,  WS:-2,  AS: 3,  MS: 3   )},

            {"Arrogant",            new SecondaryStats(5,3,3,3,3,3)},
            {"Optimistic",          new SecondaryStats(5,3,3,3,3,3)},
            {"Audacious",           new SecondaryStats(5,3,3,3,3,3)},
            {"Radical",             new SecondaryStats(5,3,3,3,3,3)},
            {"Nefarious",           new SecondaryStats(5,3,3,3,3,3)},
            {"Sly",                 new SecondaryStats(3,5,3,3,3,3)},
            {"Composed",            new SecondaryStats(3,5,3,3,3,3)},
            {"Pessimistic",         new SecondaryStats(3,5,3,3,3,3)},
            {"Zany",                new SecondaryStats(3,5,3,3,3,3)},
            {"Ferocious",           new SecondaryStats(3,5,3,3,3,3)},
            {"Prim",                new SecondaryStats(3,3,5,5,3,3)},
            {"Cold-blooded",        new SecondaryStats(3,3,5,5,3,3)},
            {"Modest",              new SecondaryStats(3,3,5,5,3,3)},
            {"Prudent",             new SecondaryStats(3,3,5,5,3,3)},
            {"Dastardly",           new SecondaryStats(3,3,5,5,3,3)},
            {"Generous",            new SecondaryStats(3,3,3,3,5,5)},
            {"Selfless",            new SecondaryStats(3,3,3,3,5,5)},
            {"Draconian",           new SecondaryStats(3,3,3,3,5,5)},
            {"Sharp-Tempered",      new SecondaryStats(3,3,3,3,5,5)},
            {"Steadfast",           new SecondaryStats(3,3,3,3,5,5)},
        }.ToFrozenDictionary();
        
        internal static readonly FrozenDictionary<string, SecondaryStats> SECONDARYTITLES = new Dictionary<string, SecondaryStats>
        {
            { "Newbie",         new SecondaryStats(2,2,2,2,2,2) },
            { "Employee",       new SecondaryStats(2,2,2,2,2,2) },
            { "Hunter",         new SecondaryStats(3,2,2,2,2,2) },
            { "Defender",       new SecondaryStats(3,2,2,2,2,2) },
            { "Researcher",     new SecondaryStats(2,3,2,2,2,2) },
            { "Analyst",        new SecondaryStats(2,3,2,2,2,2) },
            { "Strategist",     new SecondaryStats(2,3,2,2,2,2) },
            { "Negotiator",     new SecondaryStats(2,2,3,3,2,2) },
            { "Intellectual",   new SecondaryStats(2,2,3,3,2,2) },
            { "Assistant",      new SecondaryStats(2,2,3,3,2,2) },
            { "Veteran",        new SecondaryStats(2,2,2,2,3,3) },
            { "Old-timer",      new SecondaryStats(2,2,2,2,3,3) },
            { "Specialist",     new SecondaryStats(2,2,2,2,3,3) },
            { "Senior",         new SecondaryStats(3,3,3,3,3,3) },
            { "Slayer",         new SecondaryStats(5,3,3,3,3,3) },
            { "Pursuer",        new SecondaryStats(5,3,3,3,3,3) },
            { "Fire Eater",     new SecondaryStats(5,3,3,3,3,3) },
            { "Investigator",   new SecondaryStats(3,5,3,3,3,3) },
            { "Philosopher",    new SecondaryStats(3,5,3,3,3,3) },
            { "Architect",      new SecondaryStats(3,5,3,3,3,3) },
            { "Arbitrator",     new SecondaryStats(3,3,5,5,3,3) },
            { "Comprehender",   new SecondaryStats(3,3,5,5,3,3) },
            { "Unifier",        new SecondaryStats(3,3,5,5,3,3) },
            { "Commander",      new SecondaryStats(3,3,3,3,5,5) },
            { "Hero",           new SecondaryStats(3,3,3,3,5,5) },
            { "Pillar",         new SecondaryStats(3,3,3,3,5,5) },
            { "Grand Senior",   new SecondaryStats(4,4,4,4,4,4) },
        }.ToFrozenDictionary();

        //these are conditional bonuses
        internal static StatSet GlobalBonuses { get; set; } = new();

        //saved stats
        internal string Name { get; set; }

        private PrimaryStats _primaryStats;
        internal PrimaryStats PrimaryStats
        {
            get { return _primaryStats; }
            set { _primaryStats = value; Calculate(); }
        } 

        private string _primaryTitle;
        internal string PrimaryTitle
        {
            get { return _primaryTitle; }
            set { _primaryTitle = value; this.Calculate(); }
        }

        private string _secondaryTitle;
        internal string SecondaryTitle
        {
            get { return _secondaryTitle; }
            set { _secondaryTitle = value; this.Calculate(); }
        }

        private Department _department;
        internal Department Department
        {
            get { return _department; }
            set
            {
                this._department.RemoveEmployee(this);
                IsCaptain = false;
                _department = value;
                _department.AddEmployee(this);
                Calculate();
            }
        }

        private int _daysInService;
        internal int DaysInService
        {
            get { return _daysInService; }
            set { _daysInService = value; Calculate(); }
        }

        private EgoWeapon _weapon;
        internal EgoWeapon Weapon
        {
            get { return _weapon; }
            set { 
                _weapon.Used--; 
                _weapon = value; 
                _weapon.Used++; 
                Calculate(); 
            }
        }

        private EgoSuit _suit;        
        internal EgoSuit Suit
        {
            get { return _suit; }
            set {
                _suit.Used--;
                _suit = value;
                _suit.Used++;
                Calculate(); 
            }
        }

        private readonly EgoGift[] _gifts;
        internal EgoGift[] Gifts { get { return _gifts; } }
        public void AddGift(EgoGift gift)
        {
            this._gifts[(int)gift.Slot] = gift;
            this.Calculate();
        }
        public EgoGift Gift(Slot slot) { return this._gifts[(int)slot]; }

        //derived stats        
        internal bool IsCaptain { get; set; }        
        internal int[] Ranks { get; private set; } = [1, 1, 1, 1, 1];        
        internal StatSet PermanentBonuses { get; private set; } = new();        
        internal StatSet ConditionalBonuses { get; private set; } = new();        
        internal StatSet IntrinsicStats { get; private set; } = new();        
        internal FinalStats MinStats { get; private set; } = new();        
        internal FinalStats MaxStats { get; private set; } = new();        
        internal List<string> SpecialEffects { get; private set; } = [];

        public Employee(
            string name = "BongBong",
            PrimaryStats primaryStats = null,
            string primaryTitle = "Blunt",
            string secondaryTitle = "Newbie",
            Department department = null,
            int daysInService = 0,
            bool isCaptain = false,
            EgoWeapon weapon = null,
            EgoSuit suit = null,
            EgoGift[] gifts = null
            )
        {
            Name = name;
            _primaryStats = primaryStats ?? new(15,15,15,15);
            _primaryTitle = primaryTitle;
            _secondaryTitle = secondaryTitle;
            _department = department ?? Bench.Instance;
            Department.AddEmployee( this );
            _daysInService = daysInService;
            IsCaptain = isCaptain;
            _weapon = weapon ?? Default_Weapon.Instance;
            this.Weapon.Used++;
            _suit = suit ?? Default_Suit.Instance;
            this.Suit.Used++;
            _gifts = gifts ?? new EgoGift[14];
            Calculate();
        }

        public Employee(EmployeeSave save)
        {
            Name = save.Name;
            _primaryStats = save.PrimaryStats;
            _primaryTitle = save.PrimaryTitle;
            _secondaryTitle = save.SecondaryTitle;
            _department = DepartmentManager.GetByName(save.Department);
            Department.AddEmployee(this);
            _daysInService = save.DaysInService;
            _weapon = WeaponManager.GetByName(save.Weapon);
            _suit = SuitManager.GetByName(save.Suit);
            _gifts = new EgoGift[14];
            foreach (string gift in save.Gifts) this.AddGift(GiftManager.GetByName(gift));
            this.Calculate();
        }


        public void Calculate()
        {
            //Console.WriteLine("Permanent Bonuses Resistances: " + this.permanentBonuses.resistances.ToString());
            Reset();
            PermanentBonuses.SecondaryStats += PRIMARYTITLES[this.PrimaryTitle];
            PermanentBonuses.SecondaryStats += SECONDARYTITLES[this._secondaryTitle];
            ConditionalBonuses += GlobalBonuses;
            _department.ServiceBenefits(this);

            _weapon.Effect(this);
            _suit.Effect(this);

            //apply gift bonuses and special effects
            foreach (EgoGift gift in this._gifts)
            {
                if (gift != null)
                {
                    this.PermanentBonuses.SecondaryStats += gift.SecondaryStats;
                    gift.Effect(this);
                }
            }

            CalcMinStats();
            CalcMaxStats();

            CalcRank();

           
            //todo weapon calculations
        }

        //resets most derived stats to default
        private void Reset()
        {
            Ranks = [1, 1, 1, 1, 1];
            PermanentBonuses = new();
            ConditionalBonuses = new();
            IntrinsicStats = new();
            SpecialEffects = [];
        }
        private void CalcMinStats()
        {
            this.MinStats.PrimaryStats = this.PrimaryStats + this.PermanentBonuses.PrimaryStats;
            this.MinStats.SecondaryStats.HP = this.MinStats.PrimaryStats.Fortitude;
            this.MinStats.SecondaryStats.SP = this.MinStats.PrimaryStats.Prudence;
            this.MinStats.SecondaryStats.SR = this.MinStats.PrimaryStats.Temperance;
            this.MinStats.SecondaryStats.WS = this.MinStats.PrimaryStats.Temperance;
            this.MinStats.SecondaryStats.AS = this.MinStats.PrimaryStats.Justice;
            this.MinStats.SecondaryStats.MS = (int) (this.MinStats.PrimaryStats.Justice * this.PermanentBonuses.MovespeedPercent);
            this.MinStats.SecondaryStats += this.PermanentBonuses.SecondaryStats;

            this.MinStats.DamageMin = (int)((this._weapon.DamageMin + this.PermanentBonuses.DamageFlat) * this.PermanentBonuses.DamagePercent);
            this.MinStats.DamageMax = (int)((this._weapon.DamageMax + this.PermanentBonuses.DamageFlat) * this.PermanentBonuses.DamagePercent);

            //todo resistance calculations


            //White Night special case
            if (this._suit == White_Suit.Instance && White.Instance.Department != Bench.Instance)
            {
                this.MinStats.Resistances = (new Resistances(0.2, 0.2, 0.2, 0.2) * this.PermanentBonuses.Resistances);
            }
            else
            {
                this.MinStats.Resistances = this._suit.Resistances * this.PermanentBonuses.Resistances;
            }
            //Orchestra Special case
            if (Gifts[2]==Orchestra_Gift.Instance && Suit == Orchestra_Suit.Instance)
            {
                MinStats.Resistances.White = -1;
            }
        }

        private void CalcMaxStats()
        {
            this.MaxStats.PrimaryStats = this.MinStats.PrimaryStats + this.ConditionalBonuses.PrimaryStats;
            this.MaxStats.SecondaryStats.HP = this.MaxStats.PrimaryStats.Fortitude;
            this.MaxStats.SecondaryStats.SP = this.MaxStats.PrimaryStats.Prudence;
            this.MaxStats.SecondaryStats.SR = this.MaxStats.PrimaryStats.Temperance;
            this.MaxStats.SecondaryStats.WS = this.MaxStats.PrimaryStats.Temperance;
            this.MaxStats.SecondaryStats.AS = this.MaxStats.PrimaryStats.Justice;
            this.MaxStats.SecondaryStats.MS = (int)(this.MaxStats.PrimaryStats.Justice * (this.PermanentBonuses.MovespeedPercent * this.ConditionalBonuses.MovespeedPercent));

            this.MaxStats.SecondaryStats += this.PermanentBonuses.SecondaryStats;
            this.MaxStats.SecondaryStats += this.ConditionalBonuses.SecondaryStats;

            this.MaxStats.DamageMin = (int)((this._weapon.DamageMin + this.PermanentBonuses.DamageFlat + this.ConditionalBonuses.DamageFlat) * (this.PermanentBonuses.DamagePercent * this.ConditionalBonuses.DamagePercent));
            this.MaxStats.DamageMax = (int)((this._weapon.DamageMax + this.PermanentBonuses.DamageFlat + this.ConditionalBonuses.DamageFlat) * (this.PermanentBonuses.DamagePercent * this.ConditionalBonuses.DamagePercent));

            //todo resistance calculations

            //Schadenfreude special case
            if (this._suit == Schadenfreude_Suit.Instance)
            {
                this.MaxStats.Resistances = (new Resistances(0.8,0.5,0.8,1.5) *(this.PermanentBonuses.Resistances * this.ConditionalBonuses.Resistances));
            }
            else
            {
                this.MaxStats.Resistances = this.MinStats.Resistances * this.ConditionalBonuses.Resistances;
            }
        }

        public static int StatToRank(int stat)
        {
            return
            stat < 30  ? 1 :
            stat < 45  ? 2 :
            stat < 65  ? 3 :
            stat < 100 ? 4 :
                         5 ;
        }

        private void CalcRank()
        {
            //determine individual Stat ranks
            this.Ranks[0] = StatToRank(this.PrimaryStats.Fortitude);
            this.Ranks[1] = StatToRank(this.PrimaryStats.Prudence);
            this.Ranks[2] = StatToRank(this.PrimaryStats.Temperance);
            this.Ranks[3] = StatToRank(this.PrimaryStats.Justice);
            //determine employee Rank
            int points = this.Ranks[0] + this.Ranks[1] + this.Ranks[2] + this.Ranks[3];
                this.Ranks[4] =
                points <  6 ? 1 :
                points <  9 ? 2 :
                points < 12 ? 3 :
                points < 16 ? 4 :
                              5 ;
        }

        public override string ToString()
        {

            /*
             *  [Name](R)
             *  In Command for 10 Days
             *  Primary                             Secondary
             * ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
             * ┃ Damage: 100/100 - 100/100       ┃ ┃ Resistances:  R.R/R.R  W.W/W.W  ┃
             * ┃ Speed:  10.00/10.00 Range: 10   ┃ ┃               B.B/B.B  P.P/P.P  ┃
             * ┃ Type:   Black       Rank: Aleph ┃ ┃ Rank:           Aleph           ┃
             * ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
             * ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
             * ┃ Fortitude  (R)  aaa/bbb + xx/yy  ┃ Prudence   (R)  aaa/bbb + xx/yy  ┃
             * ┃┌────────────────────────────────┐┃┌────────────────────────────────┐┃
             * ┃│ Health         aaa/bbb + xx/yy │┃│ Sanity         aaa/bbb + xx/yy │┃
             * ┃└────────────────────────────────┘┃└────────────────────────────────┘┃
             * ┃ Temperance (R)  aaa/bbb + xx/yy  ┃ Justice    (R)  aaa/bbb + xx/yy  ┃
             * ┃┌────────────────────────────────┐┃┌────────────────────────────────┐┃
             * ┃│ Work Rate      aaa/bbb + xx/yy │┃│ Attack Speed   aaa/bbb + xx/yy │┃
             * ┃│ Work Speed     aaa/bbb + xx/yy │┃│ Movement Speed aaa/bbb + xx/yy │┃
             * ┃└────────────────────────────────┘┃└────────────────────────────────┘┃
             * ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
             * 
             * Special effects:
             * ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ 
             * ┃                                                                     ┃
             * ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛
             */


            string formatted;
            //add name and employee rank;
            formatted = string.Format(" {0,-20}({1})\n", this.Name, this.Ranks[4]);
            //title
            formatted += string.Format(" {0,-36}{1}\n", this.PrimaryTitle, this._secondaryTitle);
            formatted += string.Format(" In {0,-15} for {1,2} Days\n",this._department.Name, this._daysInService);

            //equip boxes
            formatted += string.Format("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓\n");
            //                          ┃ Damage: 100/100 - 100/100       ┃ ┃ Resistances:  R.R/R.R  W.W/W.W  ┃
            formatted += string.Format("┃ Damage: {0,3}/{1,3} - {2,3}/{3,3}       ┃ ┃ Resistances:  {4:F1}/{5:F1}  {6:F1}/{7:F1}  ┃\n",
                this.MinStats.DamageMin, this.MinStats.DamageMax, this.MaxStats.DamageMin, this.MaxStats.DamageMax,
                this.MinStats.Resistances.Red, this.MaxStats.Resistances.Red, this.MinStats.Resistances.White, this.MaxStats.Resistances.White
                );
            //                          ┃ Speed:  10.00/10.00 Range: 10   ┃ ┃               B.B/B.B  P.P/P.P  ┃
            formatted += string.Format("┃ Speed:  {0,5:F}/{1,5:F} Range: {2,2:D}   ┃ ┃               {3:F1}/{4:F1}  {5:F1}/{6:F1}  ┃\n",
                this.MinStats.AttackSpeed,this.MaxStats.AttackSpeed,this._weapon.Range, 
                this.MinStats.Resistances.Black, this.MaxStats.Resistances.Black,
                this.MinStats.Resistances.Pale, this.MaxStats.Resistances.Pale
                );
            //                          ┃ Type:   Black       Rank: Aleph ┃ ┃ Rank:           Aleph           ┃
            formatted += string.Format("┃ Type:   {0,5}       Rank: {1,5} ┃ ┃ Rank:           {2,5}           ┃\n",
                this._weapon.Type, this._weapon.RiskLevel, this._suit.RiskLevel
                );
            formatted += string.Format("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛\n");

            //main boxes
            formatted += string.Format("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓\n");
                                      //┃ Fortitude  (R)  aaa/bbb + xx/yy  ┃ Prudence   (R)  aaa/bbb + xx/yy  ┃
            formatted += string.Format("┃ Fortitude  ({0})  {1,3}/{2,3} + {3,2}/{4,2}  ┃ Prudence   ({5})  {6,3}/{7,3} + {8,2}/{9,2}  ┃\n",
                this.Ranks[0], this.MinStats.PrimaryStats.Fortitude, this.MaxStats.PrimaryStats.Fortitude,
                this.PermanentBonuses.PrimaryStats.Fortitude, this.PermanentBonuses.PrimaryStats.Fortitude + this.ConditionalBonuses.PrimaryStats.Fortitude,
                this.Ranks[1], this.MinStats.PrimaryStats.Prudence, this.MaxStats.PrimaryStats.Prudence,
                this.PermanentBonuses.PrimaryStats.Prudence, this.PermanentBonuses.PrimaryStats.Prudence + this.ConditionalBonuses.PrimaryStats.Prudence
                );
            formatted += string.Format("┃┌────────────────────────────────┐┃┌────────────────────────────────┐┃\n");
                                      //┃│ Health         aaa/bbb + xx/yy │┃│ Sanity         aaa/bbb + xx/yy │┃
            formatted += string.Format("┃│ Health         {0,3}/{1,3} + {2,2}/{3,2} │┃│ Sanity         {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.MinStats.SecondaryStats.HP, this.MaxStats.SecondaryStats.HP,
                this.PermanentBonuses.SecondaryStats.HP, this.PermanentBonuses.SecondaryStats.HP + this.ConditionalBonuses.SecondaryStats.HP,
                this.MinStats.SecondaryStats.SP, this.MaxStats.SecondaryStats.SP,
                this.PermanentBonuses.SecondaryStats.SP, this.PermanentBonuses.SecondaryStats.SP + this.ConditionalBonuses.SecondaryStats.SP
                );
            formatted += string.Format("┃└────────────────────────────────┘┃└────────────────────────────────┘┃\n");
                                      //┃ Temperance (R)  aaa/bbb + xx/yy  ┃ Justice    (R)  aaa/bbb + xx/yy  ┃
            formatted += string.Format("┃ Temperance ({0})  {1,3}/{2,3} + {3,2}/{4,2}  ┃ Justice    ({5})  {6,3}/{7,3} + {8,2}/{9,2}  ┃\n",
                this.Ranks[2], this.MinStats.PrimaryStats.Temperance, this.MaxStats.PrimaryStats.Temperance,
                this.PermanentBonuses.PrimaryStats.Temperance, this.PermanentBonuses.PrimaryStats.Temperance + this.ConditionalBonuses.PrimaryStats.Temperance,
                this.Ranks[3], this.MinStats.PrimaryStats.Justice, this.MaxStats.PrimaryStats.Justice,
                this.PermanentBonuses.PrimaryStats.Justice, this.PermanentBonuses.PrimaryStats.Justice + this.ConditionalBonuses.PrimaryStats.Justice
                );
            formatted += string.Format("┃┌────────────────────────────────┐┃┌────────────────────────────────┐┃\n");
                                      //┃│ Work Rate      aaa/bbb + xx/yy │┃│ Attack Speed   aaa/bbb + xx/yy │┃
            formatted += string.Format("┃│ Work Rate      {0,3}/{1,3} + {2,2}/{3,2} │┃│ Attack Speed   {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.MinStats.SecondaryStats.SR, this.MaxStats.SecondaryStats.SR,
                this.PermanentBonuses.SecondaryStats.SR, this.PermanentBonuses.SecondaryStats.SR + this.ConditionalBonuses.SecondaryStats.SR,
                this.MinStats.SecondaryStats.AS, this.MaxStats.SecondaryStats.AS,
                this.PermanentBonuses.SecondaryStats.AS, this.PermanentBonuses.SecondaryStats.AS + this.ConditionalBonuses.SecondaryStats.AS
                );
                                      //┃│ Work Speed     aaa/bbb + xx/yy │┃│ Movement Speed aaa/bbb + xx/yy │┃
            formatted += string.Format("┃│ Work Speed     {0,3}/{1,3} + {2,2}/{3,2} │┃│ Movement Speed {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.MinStats.SecondaryStats.WS, this.MaxStats.SecondaryStats.WS,
                this.PermanentBonuses.SecondaryStats.WS, this.PermanentBonuses.SecondaryStats.WS + this.ConditionalBonuses.SecondaryStats.WS,
                this.MinStats.SecondaryStats.MS, this.MaxStats.SecondaryStats.MS,
                this.PermanentBonuses.SecondaryStats.MS, this.PermanentBonuses.SecondaryStats.MS + this.ConditionalBonuses.SecondaryStats.MS
                );
            formatted += string.Format("┃└────────────────────────────────┘┃└────────────────────────────────┘┃\n");
            formatted += string.Format("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛\n");

            //special effects
            formatted += string.Format("Special effects:\n");
            formatted += string.Format("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ \n");

            foreach(string effect in this.SpecialEffects)
            {
                               formatted += string.Format("┃ {0,-67} ┃\n", effect);
            }
            formatted += string.Format("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛\n");

            return formatted;
        }
    }
}