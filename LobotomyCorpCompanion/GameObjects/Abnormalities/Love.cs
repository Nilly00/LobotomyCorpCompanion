namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Love : AbnormalityOld
    {
        public Love()
        {
            Name = "Melting Love";
            DerivedName = "Adoration";
            RiskLevel = RiskLevel.ALEPH;
            //Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(HP:5,SP:10,SR:-5,WS:-5));
        }

        /*internal override void GiftEffect(Employee employee)
        {
            if(employee.suit == this)
            {
                employee.SpecialEffects.Add("When falling below 20% HP gain a 100 RED shield that lasts for 3 seconds. 12 Second Cooldown. Half MS while shielded");
            }
        }*/
    }
}
