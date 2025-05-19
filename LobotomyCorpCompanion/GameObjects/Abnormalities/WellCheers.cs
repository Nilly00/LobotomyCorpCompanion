namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Wellcheers : AbnormalityOld
    {
        public Wellcheers()
        {
            Name = "Opened Can of Wellcheers";
            DerivedName = "Soda";
            RiskLevel = RiskLevel.ZAYIN;

            Suit = new EgoSuit(DerivedName, 15, 5, [0, 0, 0, 0, 0], RiskLevel, new Resistances(0.8, 1.0, 1.0, 2.0));

            //Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP:2));
        }
    }
}