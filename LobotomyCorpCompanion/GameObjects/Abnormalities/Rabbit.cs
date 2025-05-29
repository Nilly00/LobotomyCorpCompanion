using System.Runtime.CompilerServices;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Rabbit : Abnormality
    {
        // Singleton instance
        private static readonly Rabbit _instance = new();

        // Public accessor
        public static Rabbit Instance => _instance;

        // Private constructor to prevent external instantiation
        private Rabbit() : base(
            name: "Standard Training-Dummy Rabbit",
            riskLevel: RiskLevel.TETH,
            weapon: Rabbit_Weapon.Instance,
            suit: Rabbit_Suit.Instance,
            gift: Rabbit_Gift.Instance
            )
        {
        }
    }
}