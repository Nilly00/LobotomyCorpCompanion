namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Forsaken : AbnormalityOld
    {
        public Forsaken()
        {
            Name = "Forsaken Murderer";
            DerivedName = "Regret";
            RiskLevel = RiskLevel.TETH;
            //Gift = new EgoGift(DerivedName, Slot.Mouth_1, new SecondaryStats(HP:2,SP:2));
        }
    }
}
