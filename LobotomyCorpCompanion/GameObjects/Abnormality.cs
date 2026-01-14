namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Abnormality
    {
        //this needs to be saved
        internal bool Unlocked { get; set; }
        internal Department Department { get; set; }
        internal int ResearchLevel { get; set; }

        //unchanging
        internal string Name { get; init; }
        internal RiskLevel RiskLevel { get; init; }
        internal EgoWeapon? Weapon { get; init; }
        internal EgoSuit? Suit { get; init; }
        internal EgoGift? Gift { get; init; }

        protected Abnormality(
            string name,
            RiskLevel riskLevel,
            EgoWeapon? weapon = null,
            EgoSuit? suit = null,
            EgoGift? gift = null
            )
        {
            this.Name = name;
            this.RiskLevel = riskLevel;
            this.Weapon = weapon;
            this.Suit = suit;
            this.Gift = gift;
            this.Unlocked = false;
            this.Department = Bench.Instance;
            this.ResearchLevel = 0;
            this.Department.Abnormalities.Add(this);
        }

        internal void Unlock()
        {
            this.Unlocked = true;
            
        }
        internal void MoveToDepartment(Department department)
        {
            if (this.Department != department)
            {
                this.Department.Abnormalities.Remove(this);
                this.Department = department;
                this.Department.Abnormalities.Add(this);
            }
        }
        internal virtual void IncreaseResearchLevel() { }
    }


}
