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
            if (SaveManagament.abnormalities.TryGetValue(name, out AbnormalitySave value))
            {
                this.unlocked = value.unlocked;
                this.department = value.department;
                this.researchLevel = value.researchLevel;
            }
            else
            {
                this.unlocked = false;
                this.department = Bench.Instance;
                this.researchLevel = 0;
            }
            this.department.Abnormalities.Add(this);
        }

        internal void Unlock()
        {
            this.unlocked = true;
            this.researchLevel = 0;
        }
        internal void MoveToDepartment(Department department)
        {
            if (this.unlocked == false)
            {
                Unlock();
            }
            if (this.department != department)
            {
                this.department.Abnormalities.Remove(this);
                this.department = department;
                this.department.Abnormalities.Add(this);
            }
        }
        internal virtual void IncreaseResearchLevel() { }
    }


}
