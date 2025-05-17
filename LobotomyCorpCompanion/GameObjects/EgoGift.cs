using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects
{

    enum Slot
    {
        Brooch,
        Cheek,
        Eye,
        Face,
        Hand_1,
        Hand_2,
        Hat,
        Helmet,
        Left_back,
        Right_back,
        Mouth_1,
        Mouth_2,
        Neckwear,
        Special,
    }
    internal class EgoGift(string Name, Slot slot, SecondaryStats secondary)
    {
        readonly internal string Name = Name;
        readonly internal Slot Slot = slot;
        readonly internal SecondaryStats SecondaryStats = secondary; //HP,SP,WR,WS,AS,MS
    }
}
