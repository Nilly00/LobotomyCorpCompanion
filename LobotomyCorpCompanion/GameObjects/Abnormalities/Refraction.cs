using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Refraction : Abnormality
    {
        public Refraction()
        {
            Name = "Dimensional Refraction Variant";
            DerivedName = "Diffraction";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 50, 3, [0, 0, 0, 0, 0], DamageType.WHITE, RiskLevel, 15, 17, 3, 2.0);

            Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(SP:6));
        }
    }
}
