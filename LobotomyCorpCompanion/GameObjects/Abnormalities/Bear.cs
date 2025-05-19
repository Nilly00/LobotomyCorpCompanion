namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bear : AbnormalityOld
    {
        public Bear()
        {
            Name = "Happy Teddy Bear";
            DerivedName = "Bear Paws";
            RiskLevel = RiskLevel.HE;

            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SP:4));
        }
        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("ATTACHMENT work SR +3%");
        }
    }
}
