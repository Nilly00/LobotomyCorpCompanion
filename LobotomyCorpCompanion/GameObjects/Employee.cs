using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LobotomyCorpCompanion.GameObjects;
using LobotomyCorpCompanion.GameObjects.Abnormalities;
using static System.Net.Mime.MediaTypeNames;

namespace LobotomyCorpCompanion.GameObjects
{
    internal struct PrimaryStats(int? fortitude = null, int? prudence = null, int? temperance = null, int? justice = null)
    {
        internal int? Fortitude { get; set; } = fortitude;
        internal int? Prudence { get; set; } = prudence;
        internal int? Temperance { get; set; } = temperance;
        internal int? Justice { get; set; } = justice;

        public static PrimaryStats operator +(PrimaryStats summand1, PrimaryStats summand2)
        {
            return new PrimaryStats
            {
                Fortitude  = (summand1.Fortitude  ?? 0) + (summand2.Fortitude  ?? 0),
                Prudence   = (summand1.Prudence   ?? 0) + (summand2.Prudence   ?? 0),
                Temperance = (summand1.Temperance ?? 0) + (summand2.Temperance ?? 0),
                Justice    = (summand1.Justice    ?? 0) + (summand2.Justice    ?? 0)
            };
        }
        public override readonly string ToString() { 
            return $"Fortitude: {Fortitude}, Prudence: {Prudence}, Temperance: {Temperance}, Justice: {Justice}";
        }

    }
    internal struct SecondaryStats(int? HP = null, int? SP = null, int? SR = null, int? WS = null, int? AS = null, int? MS = null)
    {
        internal int? HP { get; set; } = HP;
        internal int? SP { get; set; } = SP;
        internal int? SR { get; set; } = SR;
        internal int? WS { get; set; } = WS;
        internal int? AS { get; set; } = AS;
        internal int? MS { get; set; } = MS;

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
    internal struct Resistances(float red, float white, float black, float pale)
    {
        internal float red = red;
        internal float white = white;
        internal float black = black;
        internal float pale = pale;
    }
    internal struct StatBoni
    {

        internal PrimaryStats primaryStats = new PrimaryStats();
        internal SecondaryStats secondaryStats = new SecondaryStats();
        internal int damageFlat = 0;
        internal double damagePercent = 1;
        internal double movespeedPercent = 1;
        internal Resistances resistances = new Resistances();
        internal float[] healing = new float[2];//hp/sp healing

        public StatBoni()
        {
        }

        public static StatBoni operator +(StatBoni summand1, StatBoni summand2)
        {
            return new StatBoni
            {
                primaryStats = summand1.primaryStats + summand2.primaryStats,
                secondaryStats = summand1.secondaryStats + summand2.secondaryStats,
                damageFlat = summand1.damageFlat + summand2.damageFlat,
                damagePercent = summand1.damagePercent * summand2.damagePercent,
                healing = new float[2] { summand1.healing[0] * summand2.healing[0], summand1.healing[1] * summand2.healing[1] },
            };
        }
    }
    internal struct StatSet
    {
        internal PrimaryStats primaryStats;
        internal SecondaryStats secondaryStats;
        internal Resistances resistances;
        internal int damage;
        internal double attackSpeed;
        public static StatSet operator +(StatSet set, StatBoni boni)
        {
            return new StatSet
            {
                primaryStats = set.primaryStats + boni.primaryStats,
                secondaryStats = set.secondaryStats + boni.secondaryStats,
                damage = (int)Math.Round((set.damage + boni.damageFlat * (1 + boni.damagePercent))),

                attackSpeed = set.attackSpeed,
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

        internal static StatBoni globalBoni;

        //saved stats
        private string Name = "BongBong";
        private PrimaryStats primaryLevels = new(15, 15, 15, 15);
        private string PrimaryTitle = "Blunt";
        private string SecondaryTitle = "Newbie";

        private Department department = Department.Departments["Bench"];
        internal int daysInService = 0;

        internal Abnormality weapon = Abnormality.Abnormalities["Default"];
        internal Abnormality suit = Abnormality.Abnormalities["Default"];
        internal Abnormality?[] gifts = new Abnormality[14];

        //derived stats
        internal bool isCaptain;
        internal int[] ranks;

        internal StatBoni permanentBoni = new();
        internal StatBoni conditionalBoni = new();

        internal StatSet minStats = new();
        internal StatSet maxStats = new();

        internal List<string> SpecialEffects;

        public Employee(string name, PrimaryStats primaryStats, string primaryTitle, string secondaryTitle, Department department, Abnormality suit, Abnormality weapon, Abnormality?[] gifts)
        {
            Name = name;
            PrimaryTitle = primaryTitle;
            SecondaryTitle = secondaryTitle;
            primaryLevels = primaryStats;
            this.department = department;
            this.suit = suit;
            this.weapon = weapon;
            this.gifts = gifts;
            Calculate();
        }

        public void Calculate()
        {
            CalcRank();
            CalcBoni();
            AddSpecialEffects();
            CalcMinStats();
            CalcMaxStats();
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
        private void CalcBoni()
        {
            //permanent boni

            //add gift stats
            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] == null) continue;
                this.permanentBoni.secondaryStats += gifts[i].Gift.SecondaryStats;
            }
            //add title boni
            this.permanentBoni.secondaryStats += PrimaryTitles[this.PrimaryTitle];
            this.permanentBoni.secondaryStats += secondaryTitles[this.SecondaryTitle];
            //add department boni
            this.department.ServiceBenefits(this);

            //temporary boni
            this.conditionalBoni += globalBoni;

        }
        private void AddSpecialEffects()
        {
            SpecialEffects.Clear();
            weapon.WeaponEffect(this);
            suit.SuitEffect(this);
            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] == null) continue;
                gifts[i].GiftEffect(this);
            }
        }
        private void CalcMinStats()
        {
            this.minStats.primaryStats = this.primaryLevels;
            this.minStats.primaryStats += this.permanentBoni.primaryStats;


            this.minStats.secondaryStats.HP = this.minStats.primaryStats.Fortitude;
            this.minStats.secondaryStats.SP = this.minStats.primaryStats.Prudence;
            this.minStats.secondaryStats.SR = this.minStats.primaryStats.Temperance;
            this.minStats.secondaryStats.WS = this.minStats.primaryStats.Temperance;
            this.minStats.secondaryStats.AS = this.minStats.primaryStats.Justice;
            this.minStats.secondaryStats.MS = this.minStats.primaryStats.Justice;
            
            this.minStats.secondaryStats += (SecondaryStats)this.permanentBoni.secondaryStats;
        }
        private void CalcMaxStats()
        {
            this.maxStats = this.minStats;
        }
    }
}
