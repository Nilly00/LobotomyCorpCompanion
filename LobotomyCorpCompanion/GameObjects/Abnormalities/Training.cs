namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Training : AbnormalityOld
    {
        public Training()
        {
            Name = "Standard Training-Dummy Rabbit";
            DerivedName = "Standard Training E.G.O";
            RiskLevel = RiskLevel.TETH;

            Suit = new EgoSuit(DerivedName, 1, 5, [0, 0, 0, 0, 0], RiskLevel, new Resistances(0.5, 1.0, 1.5, 2.0));

            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:2,SP:2));
        }
    }
}
