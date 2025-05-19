namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Orchestra : AbnormalityOld
    {
        public Orchestra()
        {
            Name = "The Silent Orchestra";
            DerivedName = "Da Capo";
            RiskLevel = RiskLevel.ALEPH;

            //Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SR:4,WS:4));
        }

        /*internal override void GiftEffect(Employee employee)
        {
            if(employee.suit == this)
            {
                //todo
                employee.SpecialEffects.Add("WHITE resist becomes -1");
            }
        }*/
    }
}
