namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Lantern : AbnormalityOld
    {
        public Lantern()
        {
            Name = "Meat Lantern";
            DerivedName = "Lantern";
            RiskLevel = RiskLevel.TETH;

            //Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP: 5));
        }
    }
}
