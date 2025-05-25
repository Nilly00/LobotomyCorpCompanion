namespace LobotomyCorpCompanion.GameObjects
{    internal abstract class EgoWeapon
    {
        internal readonly Abnormality origin;
        internal readonly string name;
        internal readonly short unlockLevel;
        internal readonly int cost;
        internal readonly int maxCount;

        internal readonly int[] requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}

        internal readonly DamageType type;
        internal readonly RiskLevel riskLevel;
        internal readonly int damageMin;
        internal readonly int damageMax;
        internal readonly int range;
        internal readonly double attackSpeed;

        protected EgoWeapon(
            Abnormality origin,
            string name,
            short unlockLevel,
            int cost,
            int maxCount,
            int[] requirements,
            DamageType type,
            RiskLevel riskLevel,
            int damageMin,int damageMax,
            int range,
            double attackSpeed)
        {
            this.origin = origin;
            this.name = name;
            this.unlockLevel = unlockLevel;
            this.cost = cost;
            this.maxCount = maxCount;
            this.requirements = requirements;
            this.type = type;
            this.riskLevel = riskLevel;
            this.damageMin = damageMin;
            this.damageMax = damageMax;
            this.range = range;
            this.attackSpeed = attackSpeed;
        }

        internal virtual bool CheckRequirements(Employee employee) {
            
            //todo implement default check
            return false;
        }
        internal virtual void Effect(Employee employee){}
        internal virtual void WeaponCalculate()
        {
            //todo write default weapon calculation
        }
        internal virtual void DualWeapon()
        {
            //todo write dual weapon calculation
        }
    }
}
