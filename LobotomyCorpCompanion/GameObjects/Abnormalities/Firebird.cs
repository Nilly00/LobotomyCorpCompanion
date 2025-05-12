using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Firebird : Abnormality
    {
        public Firebird()
        {
            name = "The Firebird";
            derivedName = "Feather of Honor";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 0, 3, [3, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Long, riskLevel, 4, 5, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName,50, 2, [3, 0, 0, 0, 3], riskLevel, [0.6, 0.6, 1.3, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hat, [0, 2, 0, 0, 4, 4]);
        }
    }
}
