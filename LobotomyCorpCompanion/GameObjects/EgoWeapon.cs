using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects
{    internal class EgoWeapon(string name, int cost, int maxCount, int[] requirements, DamageType type, RiskLevel riskLevel, int damageMin, int damageMax, int range, double attackSpeed)
    {
        internal readonly string name;
        internal readonly int cost = cost;
        internal int maxCount = maxCount;

        internal int[] requirements = requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}

        internal DamageType type = type;
        internal RiskLevel riskLevel = riskLevel;
        internal int damageMin = damageMin;
        internal int damageMax = damageMax;
        internal int range = range;
        internal double attackSpeed = attackSpeed;
    }
}
