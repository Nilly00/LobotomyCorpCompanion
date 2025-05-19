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
        public override readonly string ToString() { 
            return $"Fortitude: {Fortitude}, Prudence: {Prudence}, Temperance: {Temperance}, Justice: {Justice}";
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
                HP = summand1.HP + summand2.HP,
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
    internal class Employee
    {
        private static FrozenDictionary<string, SecondaryStats> PrimaryTitles = new Dictionary<string, SecondaryStats>{
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
        private static FrozenDictionary<string, SecondaryStats> secondaryTitles = new Dictionary<string, SecondaryStats>
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

        internal static StatSet globalBonuses;

        //saved stats
        private string Name = "BongBong";
        private PrimaryStats primaryLevels = new(15, 15, 15, 15);
        private string PrimaryTitle = "Blunt";
        private string SecondaryTitle = "Newbie";

        internal Department department = Department.Departments["Bench"];
        internal int daysInService = 0;

        internal EgoWeapon weapon = Standard_Weapon.Instance;
        internal EgoSuit suit;//todo fix up
        internal EgoGift[] gifts = new EgoGift[14];

        //derived stats
        internal int[] ranks = [1,1,1,1,1];

        internal StatSet permanentBoni = new();
        internal StatSet conditionalBoni = new();

        internal List<string> SpecialEffects;

        public Employee()
        {

        }

        public void Calculate()
        {
            CalcRank();
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
    }
}
