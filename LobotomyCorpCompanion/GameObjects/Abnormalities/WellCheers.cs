namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class WellCheers : Abnormality
    {
        public WellCheers()
        {
            name = "Opened Can of WellCheers";
            derivedName = "Soda";
            riskLevel = RiskLevel.ZAYIN;

            weapon = new EgoWeapon(derivedName, 20, 2, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.Long, riskLevel, 1, 2, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 15, 5, [0, 0, 0, 0, 0], riskLevel, [0.8, 1.0, 1.0, 2.0]);

            gift = new EgoGift(derivedName, Slot.Mouth_2, [2, 0, 0, 0, 0, 0]);
        }
    }
}