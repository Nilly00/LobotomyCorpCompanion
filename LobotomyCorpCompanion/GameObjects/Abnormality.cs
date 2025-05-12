using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Abnormality
    {
        internal required string name;
        internal string? derivedName;
        internal RiskLevel riskLevel;

        internal EgoWeapon? weapon;
        internal EgoSuit? suit;
        internal EgoGift? gift;


        public virtual void WeaponEffect(Employee employee)
        {
            //placeholder function to allow for calls
        }

        public virtual void SuitEffect(Employee employee)
        {
            //placeholder function to allow for calls
        }

        public virtual void GiftEffect(Employee employee)
        {
            //placeholder function to allow for calls
        }

    }
}
