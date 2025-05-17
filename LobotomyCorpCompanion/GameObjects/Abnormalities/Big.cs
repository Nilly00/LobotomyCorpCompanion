using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Big : Abnormality
    {
        public Big()
        {
            Name = "Big Bird";
            DerivedName = "Lamp";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 70, 1, [3, 3, 0, 0, 0], DamageType.BLACK,RiskLevel, 22, 28, 5, 3.0);

            Suit = new EgoSuit(DerivedName, 60, 1, [0, 0, 3, 3, 4], RiskLevel, [0.8, 0.7, 0.4, 1.5]);
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to BLACK damage");
        }

    }
}
