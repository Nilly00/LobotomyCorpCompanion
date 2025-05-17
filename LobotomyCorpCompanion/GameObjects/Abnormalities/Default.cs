using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Default : Abnormality
    {
        public Default()
        {
            Name = "Standard";
            DerivedName = "Standard";
            RiskLevel = RiskLevel.ZAYIN;

            Weapon = new EgoWeapon("Standard Riot Stick", 0, -1, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 4, 6, 3 ,1.0);

            Suit = new EgoSuit("Standard Uniform", 0, -1, [0, 0, 0, 0, 0], RiskLevel, [1.0, 1.0, 1.5, 2.0]);
        }
    }
}
