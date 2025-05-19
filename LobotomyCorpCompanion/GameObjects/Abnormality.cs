namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Abnormality
    {
        //this needs to be saved
        internal bool unlocked;
        internal Department department;
        internal int researchLevel;
        //unchanging
        internal readonly string name;
        internal readonly RiskLevel riskLevel;
        internal readonly EgoWeapon? weapon;
        internal readonly EgoSuit? suit;
        internal readonly EgoGift? gift;

        protected Abnormality(
            string name,
            RiskLevel riskLevel,
            EgoWeapon? weapon = null,
            EgoSuit? suit = null,
            EgoGift? gift = null
            )
        {
            this.name = name;
            this.riskLevel = riskLevel;
            this.weapon = weapon;
            this.suit = suit;
            this.gift = gift;
            this.unlocked = SaveManagament.Abnormalities[name].unlocked;
            this.department = SaveManagament.Abnormalities[name].department;
            this.researchLevel = SaveManagament.Abnormalities[name].researchLevel;
        }

        internal void Save()
        {

        }

        internal bool SameWeapon(Employee employee)
        {
            return employee.weapon == this.weapon ? true : false;
        }
        internal bool SameSuit(Employee employee)
        {
            return employee.suit == this.suit ? true : false;
        }
        internal bool SameGift(Employee employee)
        {
            foreach (EgoGift gift in employee.gifts)
            {
                if (gift == this.gift) return true;
            }
            return false;
        }

    }

}
