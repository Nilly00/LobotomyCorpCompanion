namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Plague : AbnormalityOld
    {

        public Plague()
        {
            Name = "Plague Doctor";
            DerivedName = "Benediction";
            RiskLevel = RiskLevel.ZAYIN;

            //Gift = new EgoGift(DerivedName, Slot.Special, new SecondaryStats(HP: 6, SP: 6, SR: 6, WS: 6, AS: 6, MS: 6));
        }
        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("𝔹𝕃𝔼𝕊𝕊𝔼𝔻");
        }
    }
}