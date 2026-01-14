

namespace LobotomyCorpCompanion.GameObjects
{
    public class PrimaryStats(int Fortitude = 0, int Prudence = 0, int Temperance = 0, int Justice = 0)
    {
        public int Fortitude { get; set; } = Fortitude;
        public int Prudence { get; set; } = Prudence;
        public int Temperance { get; set; } = Temperance;
        public int Justice { get; set; } = Justice;

        public static PrimaryStats operator +(PrimaryStats summand1, PrimaryStats summand2)
        {
            return new PrimaryStats
            {
                Fortitude = summand1.Fortitude + summand2.Fortitude,
                Prudence = summand1.Prudence + summand2.Prudence,
                Temperance = summand1.Temperance + summand2.Temperance,
                Justice = summand1.Justice + summand2.Justice
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
        public override string ToString()
        {
            return $"Fortitude: {Fortitude}, Prudence: {Prudence},\nTemperance: {Temperance}, Justice: {Justice}";
        }

    }
    internal class SecondaryStats(int HP = 0, int SP = 0, int SR = 0, int WS = 0, int AS = 0, int MS = 0)
    {
        public int HP { get; set; } = HP;
        public int SP { get; set; } = SP;
        public int SR { get; set; } = SR;
        public int WS { get; set; } = WS;
        public int AS { get; set; } = AS;
        public int MS { get; set; } = MS;

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

    internal abstract class StatComponent()
    {
        public PrimaryStats PrimaryStats { get; set; } = new();
        public SecondaryStats SecondaryStats { get; set; } = new();
        public Resistances Resistances { get; set; } = new();
        public double HPHealing { get; set; } = 1.0;
        public double SPHealing { get; set; } = 1.0;
    }
    internal class StatSet() : StatComponent()
    {
        public int DamageFlat { get; set; } = 0;
        public double DamagePercent { get; set; } = 1.0;
        public double AttackSpeedPercent { get; set; } = 1.0;
        public double MovespeedPercent { get; set; } = 1.0;
        public static StatSet operator +(StatSet set, StatSet boni)
        {
            return new StatSet
            {
                PrimaryStats = set.PrimaryStats + boni.PrimaryStats,
                SecondaryStats = set.SecondaryStats + boni.SecondaryStats,
                Resistances = set.Resistances * boni.Resistances,
                DamageFlat = set.DamageFlat + boni.DamageFlat,
                DamagePercent = set.DamagePercent * boni.DamagePercent,
                AttackSpeedPercent = set.AttackSpeedPercent * boni.AttackSpeedPercent,
                MovespeedPercent = set.MovespeedPercent * boni.MovespeedPercent,
                HPHealing = set.HPHealing * boni.HPHealing,
                SPHealing = set.SPHealing * boni.SPHealing
            };
        }
    }
    internal class FinalStats() : StatComponent
    {
        public int DamageMin { get; set; } = 0;
        public int DamageMax { get; set; } = 0;
        public double AttackSpeed { get; set; } = 1.0;
        public double MoveSpeed { get; set; } = 1.0;
    }
}
