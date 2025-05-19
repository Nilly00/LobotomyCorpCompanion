namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Rudolta : AbnormalityOld
    {
        public Rudolta()
        {
            Name = "Rudolta of the Sleigh";
            DerivedName = "Christmas";
            RiskLevel = RiskLevel.HE;
            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:-4,SP:8));
        }
    }
}
