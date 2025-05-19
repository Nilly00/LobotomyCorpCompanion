namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Scorched : AbnormalityOld
    {
        public Scorched()
        {
            Name = "Scorched Girl";
            DerivedName = "Fourth Match Flame";
            RiskLevel = RiskLevel.TETH;

            //Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP:4));
        }
    }
}
