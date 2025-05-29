namespace LobotomyCorpCompanion.GameObjects
{

    //todo change structs to classes
    internal class PrimaryStats(int fortitude = 0, int prudence = 0, int temperance = 0, int justice = 0)
    {
        internal int Fortitude  = fortitude;
        internal int Prudence   = prudence;
        internal int Temperance = temperance;
        internal int Justice    = justice;

        public static PrimaryStats operator +(PrimaryStats summand1, PrimaryStats summand2)
        {
            return new PrimaryStats
            {
                Fortitude  = summand1.Fortitude  + summand2.Fortitude,
                Prudence   = summand1.Prudence   + summand2.Prudence,
                Temperance = summand1.Temperance + summand2.Temperance,
                Justice    = summand1.Justice    + summand2.Justice
            };
        }

        public static PrimaryStats operator +(PrimaryStats summand1, int increase)
        {
            return new PrimaryStats
            {
                Fortitude = summand1.Fortitude += increase,
                Prudence = summand1.Prudence += increase,
                Temperance = summand1.Temperance += increase,
                Justice = summand1.Justice += increase
            };
        }
        public override string ToString() { 
            return $"Fortitude: {Fortitude}, Prudence: {Prudence},\n Temperance: {Temperance}, Justice: {Justice}";
        }

    }
    internal class SecondaryStats(int HP = 0, int SP = 0, int SR = 0, int WS = 0, int AS = 0, int MS = 0)
    {
        internal int HP = HP;
        internal int SP = SP;
        internal int SR = SR;
        internal int WS = WS;
        internal int AS = AS;
        internal int MS = MS;

        public static SecondaryStats operator +(SecondaryStats summand1, SecondaryStats summand2)
        {
            return new SecondaryStats
            {
                HP = summand1.HP  + summand2.HP,
                SP = summand1.SP + summand2.SP,
                SR = summand1.SR + summand2.SR,
                WS = summand1.WS + summand2.WS,
                AS = summand1.AS + summand2.AS,
                MS = summand1.MS + summand2.MS
            };
        }
    }
    internal class StatSet()
    {
        internal PrimaryStats primaryStats = new();
        internal SecondaryStats secondaryStats = new();
        internal Resistances resistances = new();
        internal int damageFlat = 0;
        internal double damagePercent = 1.0;
        internal double attackSpeedPercent = 1.0;
        internal double MovespeedPercent = 1.0;
        internal double HPHealing = 1.0;
        internal double SPHealing = 1.0;


        public static StatSet operator +(StatSet set, StatSet boni)
        {
            return new StatSet
            {
                primaryStats =      set.primaryStats        + boni.primaryStats,
                secondaryStats =    set.secondaryStats      + boni.secondaryStats,
                resistances =       set.resistances         * boni.resistances,
                damageFlat =        set.damageFlat          + boni.damageFlat,
                damagePercent =     set.damagePercent       * boni.damagePercent,
                attackSpeedPercent= set.attackSpeedPercent  * boni.attackSpeedPercent,
                MovespeedPercent  = set.MovespeedPercent    * boni.MovespeedPercent,
                HPHealing =         set.HPHealing           * boni.HPHealing,
                SPHealing =         set.SPHealing           * boni.SPHealing
            };
        }
    }
    internal class FinalStats()
    {
        internal PrimaryStats primaryStats = new();
        internal SecondaryStats secondaryStats = new();
        internal Resistances resistances = new();
        internal int damageMin = 0;
        internal int damageMax = 0;
        internal double attackSpeed= 1.0;
        internal double moveSpeed = 1.0;
        internal double HPHealing = 1.0;
        internal double SPHealing = 1.0;
    }

    internal class Employee
    {
        
        internal static FrozenDictionary<string, SecondaryStats> PrimaryTitles = new Dictionary<string, SecondaryStats>{
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
        
        internal static FrozenDictionary<string, SecondaryStats> SecondaryTitles = new Dictionary<string, SecondaryStats>
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
        internal static StatSet globalBonuses = new();

        //saved stats
        internal string name;
        private PrimaryStats primaryLevels;
        private string primaryTitle;
        private string secondaryTitle;        
        internal Department department;        
        internal int daysInService;        
        private EgoWeapon weapon;        
        private EgoSuit suit;        
        private readonly EgoGift[] gifts;

        //derived stats        
        internal bool isCaptain;        
        internal int[] Ranks { get; private set; } = [1, 1, 1, 1, 1];        
        internal StatSet PermanentBonuses = new();        
        internal StatSet ConditionalBonuses = new();        
        internal StatSet IntrinsicStats = new();        
        internal FinalStats MinStats = new();        
        internal FinalStats MaxStats = new();        
        internal List<string> SpecialEffects = [];

        public Employee(
            string name = "BongBong",
            PrimaryStats primaryLevels = default,
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
            this.name = name;
            if (primaryLevels.Fortitude == 0 && primaryLevels.Prudence == 0 && primaryLevels.Temperance == 0 && primaryLevels.Justice == 0)
            {
                this.primaryLevels = new PrimaryStats(15, 15, 15, 15);
            }
            else
            {
                this.primaryLevels = primaryLevels;
            }
            this.primaryTitle = primaryTitle;
            this.secondaryTitle = secondaryTitle;
            this.department = department ?? Department.list["Bench"];
            this.daysInService = daysInService;
            this.isCaptain = isCaptain;
            this.weapon = weapon ?? Default_Weapon.Instance;
            this.suit = suit ?? Default_Suit.Instance;
            this.gifts = gifts ?? new EgoGift[14];
            Calculate();
        }


        public void SetPrimary(String title)
        {
            if (PrimaryTitles.ContainsKey(title))
            {
                primaryTitle = title;
                Calculate();
            }
            else
            {
                throw new Exception("Error: Supplied Primary Title does not exist");
            }
        }
        public String GetPrimary() { return this.primaryTitle; }

        public void SetSecondary(String title)
        {
            if (SecondaryTitles.ContainsKey(title))
            {
                secondaryTitle = title;
                Calculate();
            }
            else
            {
                throw new Exception("Error: Supplied Secondary Title does not exist");
            }
        }
        public String GetSecondary() { return this.secondaryTitle; }

        public void SetPrimaryStats(PrimaryStats stats)
        {
            primaryLevels = stats;
            Calculate();
        }
        public PrimaryStats GetPrimaryStats() {  return primaryLevels; }

        public int[] GetRanks(){ return Ranks; }


        public void AddGift(EgoGift gift)
        {
            this.gifts[(int)gift.slot] = gift;
            this.Calculate();
        }
        public EgoGift[] GetGifts(){ return this.gifts; }
        public EgoGift GetGift(Slot slot){ return this.gifts[(int)slot]; }

        public void SetWeapon(EgoWeapon weapon)
        {
            this.weapon = weapon;
            this.Calculate();
        }
        public EgoWeapon GetWeapon(){ return this.weapon; }

        public void SetSuit(EgoSuit suit)
        {
            this.suit = suit;
            this.Calculate();
        }
        public EgoSuit GetSuit(){ return this.suit; }


        public void Calculate()
        {
            //Console.WriteLine("Permanent Bonuses Resistances: " + this.permanentBonuses.resistances.ToString());
            Reset();
            PermanentBonuses.secondaryStats += PrimaryTitles[this.primaryTitle];
            PermanentBonuses.secondaryStats += SecondaryTitles[this.secondaryTitle];
            ConditionalBonuses += globalBonuses;
            department.ServiceBenefits(this);

            weapon.Effect(this);
            suit.Effect(this);

            //apply gift bonuses and special effects
            foreach (EgoGift gift in this.gifts)
            {
                if (gift != null)
                {
                    this.PermanentBonuses.secondaryStats += gift.secondaryStats;
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
            this.MinStats.primaryStats = this.primaryLevels + this.PermanentBonuses.primaryStats;
            this.MinStats.secondaryStats.HP = this.MinStats.primaryStats.Fortitude;
            this.MinStats.secondaryStats.SP = this.MinStats.primaryStats.Prudence;
            this.MinStats.secondaryStats.SR = this.MinStats.primaryStats.Temperance;
            this.MinStats.secondaryStats.WS = this.MinStats.primaryStats.Temperance;
            this.MinStats.secondaryStats.AS = this.MinStats.primaryStats.Justice;
            this.MinStats.secondaryStats.MS = (int) (this.MinStats.primaryStats.Justice * this.PermanentBonuses.MovespeedPercent);
            this.MinStats.secondaryStats += this.PermanentBonuses.secondaryStats;

            this.MinStats.damageMin = (int)((this.weapon.damageMin + this.PermanentBonuses.damageFlat) * this.PermanentBonuses.damagePercent);
            this.MinStats.damageMax = (int)((this.weapon.damageMax + this.PermanentBonuses.damageFlat) * this.PermanentBonuses.damagePercent);

            //White Night special case
            if (this.suit == White_Suit.Instance && White.Instance.department != Bench.Instance)
            {
                this.MinStats.resistances = (new Resistances(0.2, 0.2, 0.2, 0.2) * this.PermanentBonuses.resistances);
            }
            else
            {
                this.MinStats.resistances = this.suit.resistances * this.PermanentBonuses.resistances;
            }
        }

        private void CalcMaxStats()
        {
            this.MaxStats.primaryStats = this.MinStats.primaryStats + this.ConditionalBonuses.primaryStats;
            this.MaxStats.secondaryStats.HP = this.MaxStats.primaryStats.Fortitude;
            this.MaxStats.secondaryStats.SP = this.MaxStats.primaryStats.Prudence;
            this.MaxStats.secondaryStats.SR = this.MaxStats.primaryStats.Temperance;
            this.MaxStats.secondaryStats.WS = this.MaxStats.primaryStats.Temperance;
            this.MaxStats.secondaryStats.AS = this.MaxStats.primaryStats.Justice;
            this.MaxStats.secondaryStats.MS = (int)(this.MaxStats.primaryStats.Justice * (this.PermanentBonuses.MovespeedPercent * this.ConditionalBonuses.MovespeedPercent));

            this.MaxStats.secondaryStats += this.PermanentBonuses.secondaryStats;
            this.MaxStats.secondaryStats += this.ConditionalBonuses.secondaryStats;

            this.MaxStats.damageMin = (int)((this.weapon.damageMin + this.PermanentBonuses.damageFlat + this.ConditionalBonuses.damageFlat) * (this.PermanentBonuses.damagePercent * this.ConditionalBonuses.damagePercent));
            this.MaxStats.damageMax = (int)((this.weapon.damageMax + this.PermanentBonuses.damageFlat + this.ConditionalBonuses.damageFlat) * (this.PermanentBonuses.damagePercent * this.ConditionalBonuses.damagePercent));

            //Schadenfreude special case
            if (this.suit == Schadenfreude_Suit.Instance)
            {
                this.MaxStats.resistances = (new Resistances(0.8,0.5,0.8,1.5) *(this.PermanentBonuses.resistances * this.ConditionalBonuses.resistances));
            }
            else
            {
                this.MaxStats.resistances = this.MinStats.resistances * this.ConditionalBonuses.resistances;
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
            this.Ranks[0] = StatToRank((int)this.primaryLevels.Fortitude);
            this.Ranks[1] = StatToRank((int)this.primaryLevels.Prudence);
            this.Ranks[2] = StatToRank((int)this.primaryLevels.Temperance);
            this.Ranks[3] = StatToRank((int)this.primaryLevels.Justice);
            //determine employee Rank
            int points = this.Ranks[0] + this.Ranks[1] + this.Ranks[2] + this.Ranks[3];
                this.Ranks[4] =
                points <  6 ? 1 :
                points <  9 ? 2 :
                points < 12 ? 3 :
                points < 16 ? 4 :
                              5 ;
        }

        public void SetDepartment(Department department)
        {
            this.department.RemoveEmployee(this);
            this.department = department;
            this.department.AddEmployee(this);
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
            formatted = String.Format(" {0,-20}({1})\n", this.name, this.Ranks[4]);
            //title
            formatted += String.Format(" {0,-36}{1}\n", this.primaryTitle, this.secondaryTitle);
            formatted += String.Format(" In {0,-15} for {1,2} Days\n",this.department.name, this.daysInService);

            //equip boxes
            formatted += String.Format("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓\n");
            //                          ┃ Damage: 100/100 - 100/100       ┃ ┃ Resistances:  R.R/R.R  W.W/W.W  ┃
            formatted += String.Format("┃ Damage: {0,3}/{1,3} - {2,3}/{3,3}       ┃ ┃ Resistances:  {4:F1}/{5:F1}  {6:F1}/{7:F1}  ┃\n",
                this.MinStats.damageMin, this.MinStats.damageMax, this.MaxStats.damageMin, this.MaxStats.damageMax,
                this.MinStats.resistances.red, this.MaxStats.resistances.red, this.MinStats.resistances.white, this.MaxStats.resistances.white
                );
            //                          ┃ Speed:  10.00/10.00 Range: 10   ┃ ┃               B.B/B.B  P.P/P.P  ┃
            formatted += String.Format("┃ Speed:  {0,5:F}/{1,5:F} Range: {2,2:D}   ┃ ┃               {3:F1}/{4:F1}  {5:F1}/{6:F1}  ┃\n",
                this.MinStats.attackSpeed,this.MaxStats.attackSpeed,this.weapon.range, 
                this.MinStats.resistances.black, this.MaxStats.resistances.black,
                this.MinStats.resistances.pale, this.MaxStats.resistances.pale
                );
            //                          ┃ Type:   Black       Rank: Aleph ┃ ┃ Rank:           Aleph           ┃
            formatted += String.Format("┃ Type:   {0,5}       Rank: {1,5} ┃ ┃ Rank:           {2,5}           ┃\n",
                this.weapon.type, this.weapon.riskLevel, this.suit.riskLevel
                );
            formatted += String.Format("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛ ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛\n");

            //main boxes
            formatted += String.Format("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓\n");
                                      //┃ Fortitude  (R)  aaa/bbb + xx/yy  ┃ Prudence   (R)  aaa/bbb + xx/yy  ┃
            formatted += String.Format("┃ Fortitude  ({0})  {1,3}/{2,3} + {3,2}/{4,2}  ┃ Prudence   ({5})  {6,3}/{7,3} + {8,2}/{9,2}  ┃\n",
                this.Ranks[0], this.MinStats.primaryStats.Fortitude, this.MaxStats.primaryStats.Fortitude,
                this.PermanentBonuses.primaryStats.Fortitude, this.PermanentBonuses.primaryStats.Fortitude + this.ConditionalBonuses.primaryStats.Fortitude,
                this.Ranks[1], this.MinStats.primaryStats.Prudence, this.MaxStats.primaryStats.Prudence,
                this.PermanentBonuses.primaryStats.Prudence, this.PermanentBonuses.primaryStats.Prudence + this.ConditionalBonuses.primaryStats.Prudence
                );
            formatted += String.Format("┃┌────────────────────────────────┐┃┌────────────────────────────────┐┃\n");
                                      //┃│ Health         aaa/bbb + xx/yy │┃│ Sanity         aaa/bbb + xx/yy │┃
            formatted += String.Format("┃│ Health         {0,3}/{1,3} + {2,2}/{3,2} │┃│ Sanity         {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.MinStats.secondaryStats.HP, this.MaxStats.secondaryStats.HP,
                this.PermanentBonuses.secondaryStats.HP, this.PermanentBonuses.secondaryStats.HP + this.ConditionalBonuses.secondaryStats.HP,
                this.MinStats.secondaryStats.SP, this.MaxStats.secondaryStats.SP,
                this.PermanentBonuses.secondaryStats.SP, this.PermanentBonuses.secondaryStats.SP + this.ConditionalBonuses.secondaryStats.SP
                );
            formatted += String.Format("┃└────────────────────────────────┘┃└────────────────────────────────┘┃\n");
                                      //┃ Temperance (R)  aaa/bbb + xx/yy  ┃ Justice    (R)  aaa/bbb + xx/yy  ┃
            formatted += String.Format("┃ Temperance ({0})  {1,3}/{2,3} + {3,2}/{4,2}  ┃ Justice    ({5})  {6,3}/{7,3} + {8,2}/{9,2}  ┃\n",
                this.Ranks[2], this.MinStats.primaryStats.Temperance, this.MaxStats.primaryStats.Temperance,
                this.PermanentBonuses.primaryStats.Temperance, this.PermanentBonuses.primaryStats.Temperance + this.ConditionalBonuses.primaryStats.Temperance,
                this.Ranks[3], this.MinStats.primaryStats.Justice, this.MaxStats.primaryStats.Justice,
                this.PermanentBonuses.primaryStats.Justice, this.PermanentBonuses.primaryStats.Justice + this.ConditionalBonuses.primaryStats.Justice
                );
            formatted += String.Format("┃┌────────────────────────────────┐┃┌────────────────────────────────┐┃\n");
                                      //┃│ Work Rate      aaa/bbb + xx/yy │┃│ Attack Speed   aaa/bbb + xx/yy │┃
            formatted += String.Format("┃│ Work Rate      {0,3}/{1,3} + {2,2}/{3,2} │┃│ Attack Speed   {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.MinStats.secondaryStats.SR, this.MaxStats.secondaryStats.SR,
                this.PermanentBonuses.secondaryStats.SR, this.PermanentBonuses.secondaryStats.SR + this.ConditionalBonuses.secondaryStats.SR,
                this.MinStats.secondaryStats.AS, this.MaxStats.secondaryStats.AS,
                this.PermanentBonuses.secondaryStats.AS, this.PermanentBonuses.secondaryStats.AS + this.ConditionalBonuses.secondaryStats.AS
                );
                                      //┃│ Work Speed     aaa/bbb + xx/yy │┃│ Movement Speed aaa/bbb + xx/yy │┃
            formatted += String.Format("┃│ Work Speed     {0,3}/{1,3} + {2,2}/{3,2} │┃│ Movement Speed {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.MinStats.secondaryStats.WS, this.MaxStats.secondaryStats.WS,
                this.PermanentBonuses.secondaryStats.WS, this.PermanentBonuses.secondaryStats.WS + this.ConditionalBonuses.secondaryStats.WS,
                this.MinStats.secondaryStats.MS, this.MaxStats.secondaryStats.MS,
                this.PermanentBonuses.secondaryStats.MS, this.PermanentBonuses.secondaryStats.MS + this.ConditionalBonuses.secondaryStats.MS
                );
            formatted += String.Format("┃└────────────────────────────────┘┃└────────────────────────────────┘┃\n");
            formatted += String.Format("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛\n");

            //special effects
            formatted += String.Format("Special effects:\n");
            formatted += String.Format("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ \n");

            foreach(string effect in this.SpecialEffects)
            {
                               formatted += String.Format("┃ {0,-67} ┃\n", effect);
            }
            formatted += String.Format("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛\n");

            return formatted;
        }
    }
}