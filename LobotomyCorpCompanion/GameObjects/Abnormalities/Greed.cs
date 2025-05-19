namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Greed : AbnormalityOld
    {
        public Greed()
        {
            Name = "The King of Greed";
            DerivedName = "Gold Rush";
            RiskLevel = RiskLevel.WAW;
            //Gift = new EgoGift(DerivedName, Slot.Hand_1, new SecondaryStats(HP:6));
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("INSTINCT SR +6%");
        }
    }
}
