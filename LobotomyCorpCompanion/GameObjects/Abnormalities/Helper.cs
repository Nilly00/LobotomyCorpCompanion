namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Helper : AbnormalityOld
    {
        public Helper()
        {
            Name = "All-Around Helper";
            DerivedName = "Grinder Mk4";
            RiskLevel = RiskLevel.HE;

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SR:2,WS:2));
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("INSIGHT SR +3%");
        }
    }
}