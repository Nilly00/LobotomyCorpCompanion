namespace LobotomyCorpCompanion.GameObjects
{
    internal struct Resistances(double red = 1.0, double white = 1.0, double black = 1.0, double pale = 1.0)
    {
        internal double red   = red;
        internal double white = white;
        internal double black = black;
        internal double pale  = pale;

        public static Resistances operator *(Resistances faktor1, Resistances faktor2)
        {
            return new Resistances
            {
                red   = faktor1.red   * faktor2.red,
                white = faktor1.white * faktor2.white,
                black = faktor1.black * faktor2.black,
                pale  = faktor1.pale  * faktor2.pale
            };
        }

        public static Resistances operator +(Resistances resistances, float bonus)
        {
            return new Resistances
            {
                red   = resistances.red   * (1 - bonus),
                white = resistances.white * (1 - bonus),
                black = resistances.black * (1 - bonus),
                pale  = resistances.pale  * (1 - bonus)
            };
        }
    }
    internal abstract class EgoSuit
    {
        internal readonly Abnormality origin;
        internal readonly string name;
        internal readonly int cost;
        internal readonly int maxCount;

        internal readonly int[] requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}

        internal readonly RiskLevel riskLeve;
        Resistances resistances;

        protected EgoSuit(
            Abnormality origin,
            string name,
            int cost,
            int maxCount,
            int[] requirements,
            RiskLevel riskLevel,
            Resistances resistances) 
        {
            this.origin = origin;
            this.name = name;
            this.cost = cost;
            this.maxCount = maxCount;
            this.requirements = requirements;
            this.riskLeve = riskLevel;
            this.resistances = resistances;
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
