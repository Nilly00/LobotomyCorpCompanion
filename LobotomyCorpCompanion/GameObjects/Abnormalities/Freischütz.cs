using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Freischütz : Abnormality
    {
        public Freischütz()
        {
            Name = "Der Freischütz";
            DerivedName = "Magic Bullet";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 40, 1, [0, 0, 3, 0, 0], DamageType.BLACK, RiskLevel.WAW, 20, 22, 50 ,2.3);

            Suit = new EgoSuit(DerivedName, 45, 1, [3, 0, 0, 3, 0], RiskLevel, [0.7, 0.7, 0.7, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP:-5,SP:-5,AS:10,MS:10));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Piercing Bullet crosses the entire room.");
            employee.SpecialEffects.Add("Friendly Fire!");
        }

        internal override void SuitEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.permanentBoni.damageFlat += 3;
            }
        }

        internal override void GiftEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.permanentBoni.damageFlat += 3;
            }
        }
    }
}
