using System;
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
            name = "1.76 MHz";
            derivedName = "Noise";
            riskLevel = RiskLevel.TETH;

            suit = new EgoSuit(derivedName, 30, 1, [0, 2, 0, 0, 0], riskLevel, [1.2, 0.7, 0.6, 2.0]);

            gift = new EgoGift(derivedName, Slot.Brooch, [0, 0, 0, 0, 0, 2]);
        }

        public override void GiftEffect(Employee employee)
        {
            if(employee.suit == this)
            {
                employee.secondaryStats[1] -= 10;
                employee.secondaryStats[4] += 10;
            }
        }
    }
}
