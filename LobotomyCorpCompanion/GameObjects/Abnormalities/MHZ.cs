using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class MHZ : Abnormality
    {
        public MHZ()
        {
            Name = "1.76 MHz";
            DerivedName = "Noise";
            RiskLevel = RiskLevel.TETH;

            Suit = new EgoSuit(DerivedName, 30, 1, [0, 2, 0, 0, 0], RiskLevel, [1.2, 0.7, 0.6, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Brooch, new SecondaryStats(AS:2));
        }

        internal override void GiftEffect(Employee employee)
        {
            if(employee.suit == this)
            {
                employee.permanentBoni.secondaryStats.SP -= 10;
                employee.permanentBoni.secondaryStats.AS += 10;
            }
        }
    }
}
