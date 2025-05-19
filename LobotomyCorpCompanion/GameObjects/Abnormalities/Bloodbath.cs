namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bloodbath : AbnormalityOld
    {
        public Bloodbath()
        {
            Name = "Bloodbath";
            DerivedName = "Wrist Cutter";
            RiskLevel = RiskLevel.TETH;

            //Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(SR:2, WS:2));
        }
    }
}
