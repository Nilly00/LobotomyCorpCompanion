using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects
{

    internal abstract class EgoEquipment
    {
        internal readonly Abnormality origin;
        internal readonly string name;
        internal readonly short unlockLevel;

        protected EgoEquipment(Abnormality origin, string name, short unlockLevel)
        {
            this.origin = origin;
            this.name = name;
            this.unlockLevel = unlockLevel;
        }

        internal virtual void Effect(Employee employee)
        {
            // Default effect does nothing
        }
    }
    internal abstract class EgoPurchasable : EgoEquipment
    {
        internal short cost;
        internal short maxCount;
        internal short[] requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}
        internal RiskLevel riskLevel;

        protected EgoPurchasable(
            Abnormality origin, 
            string name, 
            short unlockLevel, 
            short cost, 
            short maxCount, 
            short[] requirements, 
            RiskLevel riskLevel)

            : base(origin, name, unlockLevel)
        {
            this.cost = cost;
            this.maxCount = maxCount;
            this.requirements = requirements;
            this.riskLevel = riskLevel;
        }

        internal virtual bool CheckRequirements(Employee employee)
        {
            //todo implement default check
            return false;
        }
    }

    internal abstract class EgoWeapon : EgoPurchasable
    {
        internal readonly DamageType type;
        internal readonly int damageMin;
        internal readonly int damageMax;
        internal readonly int range;
        internal readonly double attackSpeed;

        protected EgoWeapon(
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
            double attackSpeed)

            : base(
                  origin,
                  name,
                  unlockLevel,
                  cost,
                  maxCount,
                  requirements,
                  riskLevel)
        {
            this.type = type;
            this.damageMin = damageMin;
            this.damageMax = damageMax;
            this.range = range;
            this.attackSpeed = attackSpeed;
        }


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

        public override string ToString()
        {
            return $"Red: {red}, White: {white}, Black: {black}, Pale: {pale}";
        }
    }
    internal abstract class EgoSuit : EgoPurchasable
    {
        internal readonly Resistances resistances;

        protected EgoSuit(
            Abnormality origin,
            string name,
            short unlockLevel,

            short cost,
            short maxCount,
            short[] requirements,
            RiskLevel riskLevel,

            Resistances resistances)

            : base(
                  origin,
                  name,
                  unlockLevel,
                  cost,
                  maxCount,
                  requirements,
                  riskLevel)
        {
            this.resistances = resistances;
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
    internal abstract class EgoGift : EgoEquipment
    {
        internal readonly Slot slot;
        internal readonly SecondaryStats secondaryStats; //HP,SP,WR,WS,AS,MS
        protected EgoGift(
            Abnormality origin,
            string name,
            short unlockLevel,

            Slot slot,
            SecondaryStats secondaryStats)

            : base(
                  origin,
                  name,
                  unlockLevel)
        {
            this.slot = slot;
            this.secondaryStats = secondaryStats;
        }

        internal void Add(Employee employee) {
            employee.gifts[(int)slot] = this;
        }
    }

    internal static class GiftManagement
    {

    }
}

