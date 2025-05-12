using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects
{
    internal class EgoSuit(string name, int cost, int maxCount, int[] requirements, RiskLevel riskLevel, double[] multipliers)
    {
        internal readonly string name = name;
        internal readonly int cost = cost;
        internal readonly int maxCount = maxCount;

        internal readonly int[] requirements = requirements; //{Fortitude, Prudence, Temperance, Justice, AgentRank}

        internal readonly RiskLevel riskLevel = riskLevel;
        double[] multipliers = multipliers;
    }
}
