using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.EGOWeapons
{
    internal sealed class Apple_Weapon : EgoWeapon
    {
        // Singleton instance
        private static readonly Apple_Weapon _instance = new Apple_Weapon();

        // Public accessor
        public static Apple_Weapon Instance => _instance;

        // Private constructor to prevent external instantiation
        private Apple_Weapon() : base(
            origin: Apple.Instance, 
            name: "Green Stem",
            unlockLevel: 4,
            cost: 50,
            maxCount: 3,
            requirements: new int[] { 0, 0, 3, 0, 0 },
            type: DamageType.BLACK,
            riskLevel: RiskLevel.WAW,
            damageMin: 8,
            damageMax: 16,
            range: 1,
            attackSpeed: 1.0)
        {
        }
    }
}