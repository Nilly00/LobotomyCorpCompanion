namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Galaxy : AbnormalityOld
    {
        public Galaxy()
        {
            Name = "Child of the Galaxy";
            DerivedName = "Our Galaxy";
            RiskLevel = RiskLevel.HE;
            //Gift = new EgoGift(DerivedName, Slot.Neckwear, new SecondaryStats(SR:3,WS:3));
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Periodically recover a small amount of HP");
        }
    }
}
