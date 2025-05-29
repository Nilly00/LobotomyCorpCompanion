namespace LobotomyCorpCompanion.GameObjects
{

    internal abstract class EgoEquipment(Abnormality origin, string name, short unlockLevel)
    {
        internal readonly Abnormality origin = origin;
        internal readonly string name = name;
        internal readonly short unlockLevel = unlockLevel;

        internal virtual void Effect(Employee employee)
        {
            // Default effect does nothing
        }

        internal bool SameWeapon(Employee employee)
        {
            return employee.GetWeapon().origin == origin;
        }

        internal bool SameSuit(Employee employee)
        {
            return employee.GetSuit().origin == origin;
        }

        internal bool SameGift(Employee employee)
        {
            foreach (EgoGift gift in employee.GetGifts())
            {
                if (gift.origin == this.origin) return true;
            }
            return false;
        }
    }
    internal abstract class EgoPurchasable(
        Abnormality origin,
        string name,
        short unlockLevel,
        short cost,
        short maxCount,
        short[] requirements,
        RiskLevel riskLevel) : EgoEquipment(origin, name, unlockLevel)
    {
        internal short cost = cost;
        internal short maxCount = maxCount;
        internal short[] requirements = requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}
        internal RiskLevel riskLevel = riskLevel;

        internal virtual bool CheckRequirements(Employee employee)
        {
            //todo implement default check
            return false;
        }
    }

    internal abstract class EgoWeapon(
        Abnormality origin,
        string name,
        short unlockLevel,

        short cost,
        short maxCount,
        short[] requirements,
        RiskLevel riskLevel,

        DamageType type,
        int damageMin,
        int damageMax,
        int range,
        double attackSpeed) : EgoPurchasable(
              origin,
              name,
              unlockLevel,
              cost,
              maxCount,
              requirements,
              riskLevel)
    {
        internal readonly DamageType type = type;
        internal readonly int damageMin = damageMin;
        internal readonly int damageMax = damageMax;
        internal readonly int range = range;
        internal readonly double attackSpeed = attackSpeed;

        internal virtual void WeaponCalculate()
        {
            //todo write default weapon calculation
        }
        internal virtual void DualWeapon()
        {
            //todo write dual weapon calculation
        }
    }

    internal struct Resistances
    {
        internal double red;
        internal double white;
        internal double black;
        internal double pale;

        internal Resistances(double Red = 1.0, double White = 1.0, double Black = 1.0, double Pale = 1.0)
        {
            red = Red;
            white = White;
            black = Black;
            pale = Pale;
        }

        public Resistances()
        {
            red = 1.0;
            white = 1.0;
            black = 1.0;
            pale = 1.0;
        }

        public static Resistances operator *(Resistances factor1, Resistances factor2)
        {
            return new Resistances
            {
                red = factor1.red * factor2.red,
                white = factor1.white * factor2.white,
                black = factor1.black * factor2.black,
                pale = factor1.pale * factor2.pale
            };
        }

        public static Resistances operator +(Resistances resistances, double bonus)
        {
            return new Resistances
            {
                red = resistances.red * (1 - bonus),
                white = resistances.white * (1 - bonus),
                black = resistances.black * (1 - bonus),
                pale = resistances.pale * (1 - bonus)
            };
        }

        public override readonly string ToString()
        {
            return $"Red: {red}, White: {white}, Black: {black}, Pale: {pale}";
        }
    }
    internal abstract class EgoSuit(
        Abnormality origin,
        string name,
        short unlockLevel,

        short cost,
        short maxCount,
        short[] requirements,
        RiskLevel riskLevel,

        Resistances resistances) : EgoPurchasable(
              origin,
              name,
              unlockLevel,
              cost,
              maxCount,
              requirements,
              riskLevel)
    {
        internal readonly Resistances resistances = resistances;
    }

    enum Slot
    {
        Brooch = 0,
        Cheek = 1,
        Eye = 2,
        Face = 3,
        Hand_1 = 4,
        Hand_2 = 5,
        Hat = 6,
        Helmet = 7,
        Left_back = 8,
        Right_back = 9,
        Mouth_1 = 10,
        Mouth_2 = 11,
        Neckwear = 12,
        Special = 13,
    }
    internal abstract class EgoGift(
        Abnormality origin,
        string name,
        short unlockLevel,

        Slot slot,
        SecondaryStats secondaryStats) : EgoEquipment(
              origin,
              name,
              unlockLevel)
    {
        internal readonly Slot slot = slot;
        internal readonly SecondaryStats secondaryStats = secondaryStats; //HP,SP,WR,WS,AS,MS
    }

}

