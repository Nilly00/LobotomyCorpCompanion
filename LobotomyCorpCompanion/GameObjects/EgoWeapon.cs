using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects
{
    enum WeaponRange
    {
       VeryShort,
       Short,
       Medium,
       Long,
       VeryLong,
    }
    enum AttackSpeed
    {
        VerySlow,
        Slow,
        Normal,
        Fast,
        VeryFast,
    }

    internal class EgoWeapon(string name, int cost, int maxCount, int[] requirements, DamageType type, WeaponRange range, RiskLevel riskLevel, int damageMin, int damageMax, AttackSpeed attackSpeed)
    {
        internal readonly string name;
        internal readonly int cost = cost;
        internal int maxCount = maxCount;

        internal int[] requirements = requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}

        internal DamageType type = type;
        internal WeaponRange range = range;
        internal RiskLevel riskLevel = riskLevel;
        internal int damageMin = damageMin;
        internal int damageMax = damageMax;
        internal AttackSpeed attackSpeed = attackSpeed;
    }
}
