namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Swan : AbnormalityOld
    {
        public Swan()
        {
            Name = "Dream of a Black Swan";
            DerivedName = "Black Swan";
            RiskLevel = RiskLevel.WAW;

            Suit = new EgoSuit(DerivedName, 50, 2, [0, 0, 3, 0, 0], RiskLevel, new Resistances(0.6, 1.2, 0.8, 1.5));
        }
    }
}