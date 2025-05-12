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
            name = "Der Freischütz";
            derivedName = "Magic Bullet";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 40, 1, [0, 0, 3, 0, 0], DamageType.BLACK, WeaponRange.VeryLong, RiskLevel.WAW, 20, 22, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 45, 1, [3, 0, 0, 3, 0], riskLevel, [0.7, 0.7, 0.7, 1.5]);

            gift = new EgoGift(derivedName, Slot.Mouth_2, [-5,-5, 0, 0,10,10]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Piercing Bullet crosses the entire room.");
            employee.SpecialEffects.Add("Friendly Fire!");
        }

        public override void SuitEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.damageBoni += 3;
            }
        }

        public override void GiftEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.damageBoni += 3;
            }
        }
    }
}
