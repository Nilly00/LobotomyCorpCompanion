namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Snow : AbnormalityOld
    {
        public Snow()
        {
            Name = "Snow Queen";
            DerivedName = "Frost Splinter";
            RiskLevel = RiskLevel.HE;

            Suit = new EgoSuit(DerivedName, 35, 2, [2, 0, 0, 0, 0], RiskLevel, new Resistances(1.3, 0.6, 0.8, 1.5));
        }
    }
}
