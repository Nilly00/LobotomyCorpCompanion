using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Apocalypse : Abnormality
    {
        public Apocalypse()
        {
            Name = "Apocalypse Bird";
            DerivedName = "Twilight";
            RiskLevel = RiskLevel.ALEPH;

            //todo special requirement
            Weapon = new EgoWeapon(DerivedName, 0, 1, [0, 0, 0, 0, 0], DamageType.SPECIAL, RiskLevel, 0, 0, 1, 1.0);
            //todo special requirement
            Suit = new EgoSuit(DerivedName, 0, 0, [0, 0, 0, 0, 0], RiskLevel, [0.0, 0.0, 0.0, 0.0]);

            Gift = new EgoGift("Through the Dark Twilight", Slot.Right_back, new SecondaryStats(7, 7, 7, 7, 7, 7));
        }

        internal override void WeaponEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }

        internal override void SuitEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }
    }
}
