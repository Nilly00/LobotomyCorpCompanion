using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Fetus_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Fetus_Weapon _instance = new Fetus_Weapon();

        // Public accessor
        public static Fetus_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Fetus_Weapon() : base(
            name: "Syrinx",
            cost: 45,
            maxCount: 1,
            requirements: new int[] { 2, 0, 0, 0, 0 },
            type: DamageType.WHITE,
            riskLevel: RiskLevel.HE,
            damageMin: 3,
            damageMax: 3,
            range: 10,
            attackSpeed: 0.5)
        {
        }
    }
}
