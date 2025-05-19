namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class WallLady : AbnormalityOld
    {
        public WallLady()
        {
            Name = "The Lady Facing the Wall";
            DerivedName = "Screaming Wedge";
            RiskLevel = RiskLevel.TETH;

            Suit = new EgoSuit(DerivedName, 30, 2, [0, 0, 0, 0, 0], RiskLevel, new Resistances(1.2, 0.6, 1.0, 2.0));
        }
    }
}
