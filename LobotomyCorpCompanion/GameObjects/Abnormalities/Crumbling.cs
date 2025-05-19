namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Crumbling : AbnormalityOld
    {
        public Crumbling()
        {
            Name = "Crumbling Armor";
            DerivedName = "Life for a Daredevil";
            RiskLevel = RiskLevel.TETH;

            //Gift = new EgoGift("Inspired Bravery", Slot.Hat, new SecondaryStats(AS:10,MS:10));
        }
        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Will die if peforming ATTACHMENT Work");
        }
    }

    internal class Crumbling_B : Crumbling
    {
        public Crumbling_B()
        {
            //Gift = new EgoGift("Reckless Foolishness Blue", Slot.Hat, new SecondaryStats(HP:-5,AS:10,MS:10));
        }
    }

    internal class Crumbling_O : Crumbling
    {
        public Crumbling_O()
        {
            //Gift = new EgoGift("Reckless Foolishness Orange", Slot.Hat, new SecondaryStats(HP: -10, AS: 15, MS: 15));
        }
    }

    internal class Crumbling_R : Crumbling
    {
        public Crumbling_R()
        {
            //Gift = new EgoGift("Reckless Foolishness Red", Slot.Hat, new SecondaryStats(HP: -20, AS: 20, MS: 20));
        }
    }

}

