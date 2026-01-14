using System.ComponentModel;

namespace LobotomyCorpCompanion.GameObjects
{

    internal abstract class EgoEquipment(Abnormality origin, string name, short unlockLevel)
    {
        internal Abnormality Origin { get; init; } = origin ;
        internal string Name { get; init; } = name;
        internal short UnlockLevel { get; init; } = unlockLevel;

        internal virtual void Effect(Employee employee)
        {
            // Default effect does nothing
        }

        internal bool SameWeapon(Employee employee)
        {
            return employee.Weapon.Origin == Origin;
        }

        internal bool SameSuit(Employee employee)
        {
            return employee.Suit.Origin == Origin;
        }

        internal bool SameGift(Employee employee)
        {
            foreach (EgoGift gift in employee.Gifts)
            {
                if (gift.Origin == this.Origin) return true;
            }
            return false;
        }

        internal virtual bool IsAvailable()
        {
            return Origin.Unlocked && Origin.ResearchLevel >= UnlockLevel;
        }
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
            unlockLevel
        )
    {
        internal Slot Slot { get; init; } = slot;
        internal SecondaryStats SecondaryStats { get; init; } = secondaryStats; //HP,SP,WR,WS,AS,MS
    }

    internal abstract class EgoPurchasable(
        Abnormality origin,
        string name,
        short unlockLevel,
        short cost,
        short maxCount,
        short[] requirements,
        RiskLevel riskLevel) : EgoEquipment(
            origin, 
            name, 
            unlockLevel
        )
    {
        internal short Cost { get; init; } = cost;
        internal short MaxCount { get; init; } = maxCount;
        internal short Used { get; set; } = 0;
        internal short[] Requirements { get; init; } = requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}
        internal RiskLevel RiskLevel { get; init; } = riskLevel;

        internal virtual bool CheckRequirements(Employee employee)
        {
            for (int i = 0; i < 4; i++)
            {
                if (employee.Ranks[i] < Requirements[i]) return false;
            }
            return true;
        }
        internal override bool IsAvailable()
        {
            return (base.IsAvailable() && ((this.MaxCount - this.Used) != 0));
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
              riskLevel
        )
    {
        internal DamageType Type { get; init; } = type;
        internal int DamageMin { get; init; } = damageMin;
        internal int DamageMax { get; init; } = damageMax;
        internal int Range { get; init; } = range;
        internal double AttackSpeed { get; init; } = attackSpeed;

        internal virtual void WeaponCalculate()
        {
            //todo write default weapon calculation
        }
        internal virtual void DualWeapon()
        {
            //todo write dual weapon calculation
        }
    }

    internal class Resistances
    {
        internal double Red { get; set; }
        internal double White { get; set; }
        internal double Black { get; set; }
        internal double Pale { get; set; }

        internal Resistances(double Red = 1.0, double White = 1.0, double Black = 1.0, double Pale = 1.0)
        {
            this.Red = Red;
            this.White = White;
            this.Black = Black;
            this.Pale = Pale;
        }

        public Resistances()
        {
            Red = 1.0;
            White = 1.0;
            Black = 1.0;
            Pale = 1.0;
        }

        public static Resistances operator *(Resistances factor1, Resistances factor2)
        {
            return new Resistances
            {
                Red = factor1.Red * factor2.Red,
                White = factor1.White * factor2.White,
                Black = factor1.Black * factor2.Black,
                Pale = factor1.Pale * factor2.Pale
            };
        }

        public static Resistances operator +(Resistances resistances, double bonus)
        {
            return new Resistances
            {
                Red = resistances.Red * (1 - bonus),
                White = resistances.White * (1 - bonus),
                Black = resistances.Black * (1 - bonus),
                Pale = resistances.Pale * (1 - bonus)
            };
        }

        public override string ToString()
        {
            return $"Red: {Red}, White: {White}, Black: {Black}, Pale: {Pale}";
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
              riskLevel
        )
    {
        internal Resistances Resistances { get; init; } = resistances;
    }
}

