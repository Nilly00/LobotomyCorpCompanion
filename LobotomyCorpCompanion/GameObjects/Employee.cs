using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace LobotomyCorpCompanion.GameObjects
{
    internal class Employee
    {
        static Dictionary<string, int[]> PrimaryTitles = new Dictionary<string, int[]>{
            { "Blunt",          new int[]{ 3, 0, 0, 0, 0, 0} },
            { "Indecisive",     new int[]{ 3,-2, 0, 0, 0, 0} },
            { "Lazy",           new int[]{ 3, 0,-2,-2, 0, 0} },
            { "Timid",          new int[]{ 3, 0, 0, 0,-2,-2} },
            { "Amicable",       new int[]{ 0, 3, 0, 0, 0, 0} },
            { "Quiet",          new int[]{-2, 3, 0, 0, 0, 0} },
            { "Stuffy",         new int[]{ 0, 3,-2,-2, 0, 0} },
            { "Suave",          new int[]{ 0, 3, 0, 0 -2,-2} },
            { "Honest",         new int[]{ 0, 0, 3, 3, 0, 0} },
            { "Earnest",        new int[]{-2, 0, 3, 3, 0, 0} },
            { "Attentive",      new int[]{ 0,-2, 3, 3, 0, 0} },
            { "Gloomy",         new int[]{ 0, 0, 3, 3,-2,-2} },
            { "Bright",         new int[]{ 0, 0, 0, 0, 3, 3} },
            { "Frivolous",      new int[]{-2, 0, 0, 0, 3, 3} },
            { "Plucky",         new int[]{ 0,-2, 0, 0, 3, 3} },
            { "Cheery",         new int[]{ 0, 0,-2,-2, 3, 3} },

            { "Arrogant",       new int[]{ 5, 3, 3, 3, 3, 3} },
            { "Optimistic",     new int[]{ 5, 3, 3, 3, 3, 3} },
            { "Audacious",      new int[]{ 5, 3, 3, 3, 3, 3} },
            { "Radical",        new int[]{ 5, 3, 3, 3, 3, 3} },
            { "Nefarious",      new int[]{ 5, 3, 3, 3, 3, 3} },
            { "Sly",            new int[]{ 3, 5, 3, 3, 3, 3} },
            { "Composed",       new int[]{ 3, 5, 3, 3, 3, 3} },
            { "Pessimistic",    new int[]{ 3, 5, 3, 3, 3, 3} },
            { "Zany",           new int[]{ 3, 5, 3, 3, 3, 3} },
            { "Ferocious",      new int[]{ 3, 5, 3, 3, 3, 3} },
            { "Prim",           new int[]{ 3, 3, 5, 5, 3, 3} },
            { "Cold-blooded",   new int[]{ 3, 3, 5, 5, 3, 3} },
            { "Modest",         new int[]{ 3, 3, 5, 5, 3, 3} },
            { "Prudent",        new int[]{ 3, 3, 5, 5, 3, 3} },
            { "Dastardly",      new int[]{ 3, 3, 5, 5, 3, 3} },
            { "Generous",       new int[]{ 3, 3, 3, 3, 5, 5} },
            { "Selfless",       new int[]{ 3, 3, 3, 3, 5, 5} },
            { "Draconian",      new int[]{ 3, 3, 3, 3, 5, 5} },
            { "Sharp-Tempered", new int[]{ 3, 3, 3, 3, 5, 5} },
            { "Steadfast",      new int[]{ 3, 3, 3, 3, 5, 5} },
        };
        static Dictionary<string, int[]> secondaryTitles = new Dictionary<string, int[]>
        {
            { "Newbie",         new int[]{ 2, 2, 2, 2, 2, 2} },

            { "Employee",       new int[]{ 2, 2, 2, 2, 2, 2} },

            { "Hunter",         new int[]{ 3, 2, 2, 2, 2, 2} },
            { "Defender",       new int[]{ 3, 2, 2, 2, 2, 2} },
            { "Researcher",     new int[]{ 2, 3, 2, 2, 2, 2} },
            { "Analyst",        new int[]{ 2, 3, 2, 2, 2, 2} },
            { "Strategist",     new int[]{ 2, 3, 2, 2, 2, 2} },
            { "Negotiator",     new int[]{ 2, 2, 3, 3, 2, 2} },
            { "Intellectual",   new int[]{ 2, 2, 3, 3, 2, 2} },
            { "Assistant",      new int[]{ 2, 2, 3, 3, 2, 2} },
            { "Veteran",        new int[]{ 2, 2, 2, 2, 3, 3} },
            { "Old-timer",      new int[]{ 2, 2, 2, 2, 3, 3} },
            { "Specialist",     new int[]{ 2, 2, 2, 2, 3, 3} },
            { "Senior",         new int[]{ 3, 3, 3, 3, 3, 3} },

            { "Slayer",         new int[]{ 5, 3, 3, 3, 3, 3} },
            { "Pursuer",        new int[]{ 5, 3, 3, 3, 3, 3} },
            { "Fire Eater",     new int[]{ 5, 3, 3, 3, 3, 3} },
            { "Investigator",   new int[]{ 3, 5, 3, 3, 3, 3} },
            { "Philosopher",    new int[]{ 3, 5, 3, 3, 3, 3} },
            { "Architect",      new int[]{ 3, 5, 3, 3, 3, 3} },
            { "Arbitrator",     new int[]{ 3, 3, 5, 5, 3, 3} },
            { "Comprehender",   new int[]{ 3, 3, 5, 5, 3, 3} },
            { "Unifier",        new int[]{ 3, 3, 5, 5, 3, 3} },
            { "Commander",      new int[]{ 3, 3, 3, 3, 5, 5} },
            { "Hero",           new int[]{ 3, 3, 3, 3, 5, 5} },
            { "Pillar",         new int[]{ 3, 3, 3, 3, 5, 5} },
            { "Grand Senior",   new int[]{ 4, 4, 4, 4, 4, 4} },

        };

        //saved stats
        private string Name = "BongBong";
        private int[] primaryStats = [15,15,15,15];
        private string PrimaryTitle = "Blunt";
        private string SecondaryTitle = "Newbie";
        private Department department;
        private int daysInService = 0;
        internal Abnormality? weapon;
        internal Abnormality? suit;
        internal Abnormality?[] gifts;

        //derived stats
        internal int[] ranks;
        internal int[] secondaryStats;// HP, SP, SR, WS, AS, MS
        internal double[] resistances;
        internal List<string> SpecialEffects;
        internal double damageBoni = 0;

        public Employee(string name, int[] primaryStats, string primaryTitle, string secondaryTitle, Department department, Abnormality? suit, Abnormality? weapon, Abnormality?[] gifts)
        {
            Name = name;
            PrimaryTitle = primaryTitle;
            SecondaryTitle = secondaryTitle;
            this.department = department;
            this.suit = suit;
            this.weapon = weapon;
            this.gifts = gifts;
            //calculate derived stats
            CalculateRank();
            CalculateSecondaryStats();
            AddSpecialEffects();
        }

        private void CalculateRank()
        {
            for (int i = 0; i < 3; i++)
            {
                this.ranks[i] +=
                this.primaryStats[i] <  30 ? 1 :
                this.primaryStats[i] <  45 ? 2 :
                this.primaryStats[i] <  65 ? 3 :
                this.primaryStats[i] < 100 ? 4 :
                                             5 ;
            }

            int points = 0;
            for (int i = 0; i < 3; i++)
            {
                points += ranks[i];
            }
                this.ranks[4] =
                points <  6 ? 1 :
                points <  9 ? 2 :
                points < 12 ? 3 :
                points < 16 ? 4 :
                              5 ;
        }

        private void CalculateSecondaryStats()
        {
            //derive from base stats
            secondaryStats[0] = primaryStats[0];    //HP = Fortitude
            secondaryStats[1] = primaryStats[1];    //SP = Prudence
            secondaryStats[2] = primaryStats[2];    //SR = Temperance
            secondaryStats[3] = primaryStats[2];    //WS = Temperance
            secondaryStats[4] = primaryStats[3];    //AS = Justice
            secondaryStats[5] = primaryStats[3];    //MS = Justice

            //add Title Boni
            for (int i = 0; i < 6; i++)
            {
                secondaryStats[i] += PrimaryTitles[PrimaryTitle][i];
                secondaryStats[i] += secondaryTitles[SecondaryTitle][i];
            }
            //add gift boni
            if (gifts != null)
            {
                for (int i = 0; i < gifts.Length; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        secondaryStats[j] += gifts[i].gift.SecondaryStats[j];
                    }
                }
            }
            //todo add Department clerk Boni
            //todo add Department boni
        }

        private void AddSpecialEffects()
        {
            SpecialEffects.Clear();
            weapon.WeaponEffect(this);
            suit.SuitEffect(this);
            for (int i = 0; i < gifts.Length; i++)
            {
                gifts[i].GiftEffect(this);
            }
        }

    }
}
