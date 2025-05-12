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
            name = "Dimensional Refraction Variant";
            derivedName = "Diffraction";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 50, 3, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Short, riskLevel, 15, 17, AttackSpeed.Normal);

            gift = new EgoGift(derivedName, Slot.Helmet, [0, 6, 0, 0, 0, 0]);
        }
    }
}
