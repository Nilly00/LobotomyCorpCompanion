namespace LobotomyCorpCompanion.GameObjects
{
    internal struct PrimaryStats(int fortitude = 0, int prudence = 0, int temperance = 0, int justice = 0)
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
        public override readonly string ToString() { 
            return $"Fortitude: {Fortitude}, Prudence: {Prudence},\n Temperance: {Temperance}, Justice: {Justice}";
        }

    }
    internal struct SecondaryStats(int HP = 0, int SP = 0, int SR = 0, int WS = 0, int AS = 0, int MS = 0)
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
    internal struct StatSet()
    {
        internal PrimaryStats primaryStats = new PrimaryStats();
        internal SecondaryStats secondaryStats = new SecondaryStats();
        internal Resistances resistances = new Resistances();
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
    internal struct FinalStats()
    {
        internal PrimaryStats primaryStats = new PrimaryStats();
        internal SecondaryStats secondaryStats = new SecondaryStats();
        internal Resistances resistances = new Resistances();
        internal int damageMin = 0;
        internal int damageMax = 0;
        internal double attackSpeed= 1.0;
        internal double moveSpeed = 1.0;
        internal double HPHealing = 1.0;
        internal double SPHealing = 1.0;
    }
    internal class Employee
    {
        internal static FrozenDictionary<string, SecondaryStats> primaryTitles = new Dictionary<string, SecondaryStats>{
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
        internal static FrozenDictionary<string, SecondaryStats> secondaryTitles = new Dictionary<string, SecondaryStats>
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
        private string name = "BongBong";
        private PrimaryStats primaryLevels = new(15, 15, 15, 15);
        private string primaryTitle = "Blunt";
        private string secondaryTitle = "Newbie";

        internal Department department = Department.list["Bench"];
        internal int daysInService = 0;
        internal bool isCaptain = false;

        internal EgoWeapon weapon = Default_Weapon.Instance;
        internal EgoSuit suit = Default_Suit.Instance;
        internal EgoGift[] gifts = new EgoGift[14];

        //derived stats
        internal int[] ranks = [1,1,1,1,1];

        internal StatSet permanentBonuses = new();
        internal StatSet conditionalBonuses = new();

        internal List<string> SpecialEffects= new();

        internal StatSet intrinsicStats= new();
        internal FinalStats minStats = new();
        internal FinalStats maxStats = new();

        public Employee()
        {
            this.Calculate();
        }

        public Employee(string name,
            PrimaryStats primaryLevels, 
            string primaryTitle,
            string secondaryTitle,
            Department department,
            int daysInService,
            bool isCaptain,
            EgoWeapon weapon,
            EgoSuit suit,
            EgoGift[] gifts
            )
        {
            this.name = name;
            this.primaryLevels = primaryLevels;
            this.primaryTitle = primaryTitle;
            this.secondaryTitle = secondaryTitle;
            this.department = department;
            this.daysInService = daysInService;
            this.isCaptain = isCaptain;
            this.weapon = weapon;
            this.suit = suit;
            this.gifts = gifts;
            this.Calculate();
        }

        public void Calculate()
        {
            //Console.WriteLine("Permanent Bonuses Resistances: " + this.permanentBonuses.resistances.ToString());
            this.permanentBonuses.secondaryStats += primaryTitles[this.primaryTitle];
            this.permanentBonuses.secondaryStats += secondaryTitles[this.secondaryTitle];
            this.conditionalBonuses += globalBonuses;
            this.department.ServiceBenefits(this);

            this.weapon.Effect(this);
            this.suit.Effect(this);

            //apply gift bonuses and special effects
            foreach (EgoGift gift in this.gifts)
            {
                if (gift != null)
                {
                    this.permanentBonuses.secondaryStats += gift.secondaryStats;
                    gift.Effect(this);
                }
            }



            CalcMinStats();
            CalcMaxStats();

            CalcRank();


            //todo weapon calculations
        }

        private void CalcMinStats()
        {
            this.minStats.primaryStats = this.primaryLevels + this.permanentBonuses.primaryStats;
            this.minStats.secondaryStats.HP = this.minStats.primaryStats.Fortitude;
            this.minStats.secondaryStats.SP = this.minStats.primaryStats.Prudence;
            this.minStats.secondaryStats.SR = this.minStats.primaryStats.Temperance;
            this.minStats.secondaryStats.WS = this.minStats.primaryStats.Temperance;
            this.minStats.secondaryStats.AS = this.minStats.primaryStats.Justice;
            this.minStats.secondaryStats.MS = (int) (this.minStats.primaryStats.Justice * this.permanentBonuses.MovespeedPercent);
            this.minStats.secondaryStats += this.permanentBonuses.secondaryStats;

            this.minStats.damageMin = (int)((this.weapon.damageMin + this.permanentBonuses.damageFlat) * this.permanentBonuses.damagePercent);
            this.minStats.damageMax = (int)((this.weapon.damageMax + this.permanentBonuses.damageFlat) * this.permanentBonuses.damagePercent);

            //White Night special case
            if (this.suit == White_Suit.Instance && White.Instance.department != Bench.Instance)
            {
                this.minStats.resistances = (new Resistances(0.2, 0.2, 0.2, 0.2) * this.permanentBonuses.resistances);
            }
            else
            {
                this.minStats.resistances = this.suit.resistances * this.permanentBonuses.resistances;
            }
        }

        private void CalcMaxStats()
        {
            this.maxStats.primaryStats = this.minStats.primaryStats + this.conditionalBonuses.primaryStats;
            this.maxStats.secondaryStats.HP = this.maxStats.primaryStats.Fortitude;
            this.maxStats.secondaryStats.SP = this.maxStats.primaryStats.Prudence;
            this.maxStats.secondaryStats.SR = this.maxStats.primaryStats.Temperance;
            this.maxStats.secondaryStats.WS = this.maxStats.primaryStats.Temperance;
            this.maxStats.secondaryStats.AS = this.maxStats.primaryStats.Justice;
            this.maxStats.secondaryStats.MS = (int)(this.maxStats.primaryStats.Justice * (this.permanentBonuses.MovespeedPercent * this.conditionalBonuses.MovespeedPercent));

            this.maxStats.secondaryStats += this.permanentBonuses.secondaryStats;
            this.maxStats.secondaryStats += this.conditionalBonuses.secondaryStats;

            this.maxStats.damageMin = (int)((this.weapon.damageMin + this.permanentBonuses.damageFlat + this.conditionalBonuses.damageFlat) * (this.permanentBonuses.damagePercent * this.conditionalBonuses.damagePercent));
            this.maxStats.damageMax = (int)((this.weapon.damageMax + this.permanentBonuses.damageFlat + this.conditionalBonuses.damageFlat) * (this.permanentBonuses.damagePercent * this.conditionalBonuses.damagePercent));

            //Schadenfreude special case
            if (this.suit == Schadenfreude_Suit.Instance)
            {
                this.maxStats.resistances = (new Resistances(0.8,0.5,0.8,1.5) *(this.permanentBonuses.resistances * this.conditionalBonuses.resistances));
            }
            else
            {
                this.maxStats.resistances = this.minStats.resistances * this.conditionalBonuses.resistances;
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
            this.ranks[0] = StatToRank((int)this.primaryLevels.Fortitude);
            this.ranks[1] = StatToRank((int)this.primaryLevels.Prudence);
            this.ranks[2] = StatToRank((int)this.primaryLevels.Temperance);
            this.ranks[3] = StatToRank((int)this.primaryLevels.Justice);
            //determine employee Rank
            int points = this.ranks[0] + this.ranks[1] + this.ranks[2] + this.ranks[3];
                this.ranks[4] =
                points <  6 ? 1 :
                points <  9 ? 2 :
                points < 12 ? 3 :
                points < 16 ? 4 :
                              5 ;
        }

        public void MoveToDepartment(Department department)
        {
            this.department.RemoveEmployee(this);
            this.department = department;
            this.department.AddEmployee(this);
        }

        public void AddGift(EgoGift gift)
        {
            this.gifts[(int)gift.slot]= gift;
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
            formatted = String.Format(" {0,-20}({1})\n", this.name, this.ranks[4]);
            //title
            formatted += String.Format(" {0,-36}{1}\n", this.primaryTitle, this.secondaryTitle);
            formatted += String.Format(" In {0,-15} for {1,2} Days\n",this.department.name, this.daysInService);

            //equip boxes
            formatted += String.Format("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓ ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓\n");
            //                          ┃ Damage: 100/100 - 100/100       ┃ ┃ Resistances:  R.R/R.R  W.W/W.W  ┃
            formatted += String.Format("┃ Damage: {0,3}/{1,3} - {2,3}/{3,3}       ┃ ┃ Resistances:  {4:F1}/{5:F1}  {6:F1}/{7:F1}  ┃\n",
                this.minStats.damageMin, this.minStats.damageMax, this.maxStats.damageMin, this.maxStats.damageMax,
                this.minStats.resistances.red, this.maxStats.resistances.red, this.minStats.resistances.white, this.maxStats.resistances.white
                );
            //                          ┃ Speed:  10.00/10.00 Range: 10   ┃ ┃               B.B/B.B  P.P/P.P  ┃
            formatted += String.Format("┃ Speed:  {0,5:F}/{1,5:F} Range: {2,2:D}   ┃ ┃               {3:F1}/{4:F1}  {5:F1}/{6:F1}  ┃\n",
                this.minStats.attackSpeed,this.maxStats.attackSpeed,this.weapon.range, 
                this.minStats.resistances.black, this.maxStats.resistances.black,
                this.minStats.resistances.pale, this.maxStats.resistances.pale
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
                this.ranks[0], this.minStats.primaryStats.Fortitude, this.maxStats.primaryStats.Fortitude,
                this.permanentBonuses.primaryStats.Fortitude, this.permanentBonuses.primaryStats.Fortitude + this.conditionalBonuses.primaryStats.Fortitude,
                this.ranks[1], this.minStats.primaryStats.Prudence, this.maxStats.primaryStats.Prudence,
                this.permanentBonuses.primaryStats.Prudence, this.permanentBonuses.primaryStats.Prudence + this.conditionalBonuses.primaryStats.Prudence
                );
            formatted += String.Format("┃┌────────────────────────────────┐┃┌────────────────────────────────┐┃\n");
                                      //┃│ Health         aaa/bbb + xx/yy │┃│ Sanity         aaa/bbb + xx/yy │┃
            formatted += String.Format("┃│ Health         {0,3}/{1,3} + {2,2}/{3,2} │┃│ Sanity         {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.minStats.secondaryStats.HP, this.maxStats.secondaryStats.HP,
                this.permanentBonuses.secondaryStats.HP, this.permanentBonuses.secondaryStats.HP + this.conditionalBonuses.secondaryStats.HP,
                this.minStats.secondaryStats.SP, this.maxStats.secondaryStats.SP,
                this.permanentBonuses.secondaryStats.SP, this.permanentBonuses.secondaryStats.SP + this.conditionalBonuses.secondaryStats.SP
                );
            formatted += String.Format("┃└────────────────────────────────┘┃└────────────────────────────────┘┃\n");
                                      //┃ Temperance (R)  aaa/bbb + xx/yy  ┃ Justice    (R)  aaa/bbb + xx/yy  ┃
            formatted += String.Format("┃ Temperance ({0})  {1,3}/{2,3} + {3,2}/{4,2}  ┃ Justice    ({5})  {6,3}/{7,3} + {8,2}/{9,2}  ┃\n",
                this.ranks[2], this.minStats.primaryStats.Temperance, this.maxStats.primaryStats.Temperance,
                this.permanentBonuses.primaryStats.Temperance, this.permanentBonuses.primaryStats.Temperance + this.conditionalBonuses.primaryStats.Temperance,
                this.ranks[3], this.minStats.primaryStats.Justice, this.maxStats.primaryStats.Justice,
                this.permanentBonuses.primaryStats.Justice, this.permanentBonuses.primaryStats.Justice + this.conditionalBonuses.primaryStats.Justice
                );
            formatted += String.Format("┃┌────────────────────────────────┐┃┌────────────────────────────────┐┃\n");
                                      //┃│ Work Rate      aaa/bbb + xx/yy │┃│ Attack Speed   aaa/bbb + xx/yy │┃
            formatted += String.Format("┃│ Work Rate      {0,3}/{1,3} + {2,2}/{3,2} │┃│ Attack Speed   {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.minStats.secondaryStats.SR, this.maxStats.secondaryStats.SR,
                this.permanentBonuses.secondaryStats.SR, this.permanentBonuses.secondaryStats.SR + this.conditionalBonuses.secondaryStats.SR,
                this.minStats.secondaryStats.AS, this.maxStats.secondaryStats.AS,
                this.permanentBonuses.secondaryStats.AS, this.permanentBonuses.secondaryStats.AS + this.conditionalBonuses.secondaryStats.AS
                );
                                      //┃│ Work Speed     aaa/bbb + xx/yy │┃│ Movement Speed aaa/bbb + xx/yy │┃
            formatted += String.Format("┃│ Work Speed     {0,3}/{1,3} + {2,2}/{3,2} │┃│ Movement Speed {4,3}/{5,3} + {6,2}/{7,2} │┃\n",
                this.minStats.secondaryStats.WS, this.maxStats.secondaryStats.WS,
                this.permanentBonuses.secondaryStats.WS, this.permanentBonuses.secondaryStats.WS + this.conditionalBonuses.secondaryStats.WS,
                this.minStats.secondaryStats.MS, this.maxStats.secondaryStats.MS,
                this.permanentBonuses.secondaryStats.MS, this.permanentBonuses.secondaryStats.MS + this.conditionalBonuses.secondaryStats.MS
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