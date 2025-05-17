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
            Name = "Crumbling Armor";
            DerivedName = "Life for a Daredevil";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 35, 1, [0, 0, 2, 0, 0], DamageType.PALE, RiskLevel.HE, 7, 9, 4, 1.3);

            Suit = new EgoSuit(DerivedName, 30, 1, [0, 2, 0, 0, 0], RiskLevel, [0.6, 0.9, 0.9, 2.0]);

            Gift = new EgoGift("Inspired Bravery", Slot.Hat, new SecondaryStats(AS:10,MS:10));
        }
        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Will die if peforming ATTACHMENT Work");
        }
    }

    internal class Crumbling_B : Crumbling
    {
        public Crumbling_B()
        {
            Gift = new EgoGift("Reckless Foolishness Blue", Slot.Hat, new SecondaryStats(HP:-5,AS:10,MS:10));
        }
    }

    internal class Crumbling_O : Crumbling
    {
        public Crumbling_O()
        {
            Gift = new EgoGift("Reckless Foolishness Orange", Slot.Hat, new SecondaryStats(HP: -10, AS: 15, MS: 15));
        }
    }

    internal class Crumbling_R : Crumbling
    {
        public Crumbling_R()
        {
            Gift = new EgoGift("Reckless Foolishness Red", Slot.Hat, new SecondaryStats(HP: -20, AS: 20, MS: 20));
        }
    }

}

