using System.Runtime.Versioning;

namespace LobotomyCorpCompanion.GameObjects
{
    internal struct Resistances
    {
        internal double red;
        internal double white;
        internal double black;
        internal double pale;

        internal Resistances(double Red = 1.0, double White = 1.0, double Black = 1.0, double Pale = 1.0)
        {
            red   = Red;
            white = White;
            black = Black;
            pale  = Pale;
        }

        public Resistances()
        {
            red   = 1.0;
            white = 1.0;
            black = 1.0;
            pale  = 1.0;
        }

        public static Resistances operator *(Resistances factor1, Resistances factor2)
        {
            return new Resistances
            {
                red   = factor1.red   * factor2.red,
                white = factor1.white * factor2.white,
                black = factor1.black * factor2.black,
                pale  = factor1.pale  * factor2.pale
            };
        }

        public static Resistances operator +(Resistances resistances, double bonus)
        {
            return new Resistances
            {
                red   = resistances.red   * (1 - bonus),
                white = resistances.white * (1 - bonus),
                black = resistances.black * (1 - bonus),
                pale  = resistances.pale  * (1 - bonus)
            };
        }

        public override string ToString()
        {
            return $"Red: {red}, White: {white}, Black: {black}, Pale: {pale}";
        }
    }
    internal abstract class EgoSuit
    {
        internal readonly Abnormality origin;
        internal readonly string name;
        internal readonly short unlockLevel;
        internal readonly int cost;
        internal readonly int maxCount;

        internal readonly int[] requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}

        internal readonly RiskLevel riskLevel;
        internal readonly Resistances resistances;

        protected EgoSuit(
            Abnormality origin,
            string name,
            short unlockLevel,
            int cost,
            int maxCount,
            int[] requirements,
            RiskLevel riskLevel,
            Resistances resistances) 
        {
            this.origin = origin;
            this.name = name;
            this.unlockLevel = unlockLevel;
            this.cost = cost;
            this.maxCount = maxCount;
            this.requirements = requirements;
            this.riskLevel = riskLevel;
            this.resistances = resistances;

            //System.Console.WriteLine($"EgoSuit {name} created: {resistances.ToString()}");
        }

        internal virtual bool CheckRequirements(Employee employee)
        {
            //todo implement default check
            return false;
        }

        internal virtual void Effect(Employee employee)
        {
            
        }
    }
}
