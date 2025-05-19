namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class OneSin : AbnormalityOld
    {

        public OneSin()
        {
            Name = "One Sin and Hundreds of Good Deeds";
            DerivedName = "Penitence";
            RiskLevel = RiskLevel.ZAYIN;

            //Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SP: 2));
        }
        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Work Success Rate +10% with One Sin");
        }
    }
}
