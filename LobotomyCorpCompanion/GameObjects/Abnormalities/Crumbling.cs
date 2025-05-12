using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Crumbling : Abnormality
    {
        public Crumbling()
        {
            name = "Crumbling Armor";
            derivedName = "Life for a Daredevil";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 35, 1, [0, 0, 2, 0, 0], DamageType.PALE, WeaponRange.Medium, RiskLevel.HE, 7, 9, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 30, 1, [0, 2, 0, 0, 0], riskLevel, [0.6, 0.9, 0.9, 2.0]);

            gift = new EgoGift("Inspired Bravery", Slot.Hat, [0, 0, 0, 0, 10, 10]);
        }
        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Will die if peforming ATTACHMENT Work");
        }
    }

    internal class Crumbling_B : Crumbling
    {
        public Crumbling_B()
        {
            gift = new EgoGift("Reckless Foolishness Blue", Slot.Hat, [-5, 0, 0, 0, 10, 10]);
        }
    }

    internal class Crumbling_O : Crumbling
    {
        public Crumbling_O()
        {
            gift = new EgoGift("Reckless Foolishness Orange", Slot.Hat, [-10, 0, 0, 0, 15, 15]);
        }
    }

    internal class Crumbling_R : Crumbling
    {
        public Crumbling_R()
        {
            gift = new EgoGift("Reckless Foolishness Red", Slot.Hat, [-20, 0, 0, 0, 20, 20]);
        }
    }

}

