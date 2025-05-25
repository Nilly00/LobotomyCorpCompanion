namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Abnormality
    {
        internal static List<Abnormality> List= new List<Abnormality>
        {
            Alriune.Instance,
            Apocalypse.Instance,
            Army.Instance,
            Bald.Instance,
            Bear.Instance,
            Beauty.Instance,
            Bee.Instance,
            Big.Instance,
            Bloodbath.Instance,
            Butterflies.Instance,
            Censored.Instance,
            Cherry.Instance,
            Crumbling.Instance,
            Current.Instance,
            Cute.Instance,
            Default.Instance,
            Despair.Instance,
            Dont.Instance,
            Dream.Instance,
            Fairy.Instance,
            Fetus.Instance,
            Firebird.Instance,
            Forsaken.Instance,
            Fragments.Instance,
            Freischütz.Instance,
            Galaxy.Instance,
            Greed.Instance,
            Hatred.Instance,
            Heaven.Instance,
            Helper.Instance,
            Judgement.Instance,
            Laetitia.Instance,
            Love.Instance,
            Luna.Instance,
            MHZ.Instance,
            Monk.Instance,
            Nest.Instance,
            Nothing.Instance,
            OldLady.Instance,
            OneSin.Instance,
            Orchestra.Instance,
            Parasite.Instance,
            Plague.Instance,
            Porccubus.Instance,
            Prince.Instance,
            Punishing.Instance,
            Refraction.Instance,
            Ridinghood.Instance,
            Rudolta.Instance,
            Scarecrow.Instance,
            Schadenfreude.Instance,
            Scorched.Instance,
            Shoes.Instance,
            Shy.Instance,
            Singing.Instance,
            Smiling.Instance,
            Snow.Instance,
            Spider.Instance,
            Star.Instance,
            Swan.Instance,
            Rabbit.Instance,
            WallLady.Instance,
            Wellcheers.Instance,
            White.Instance,
            Wolf.Instance,
            Woodsman.Instance,
            Yin.Instance

        };


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
            if (SaveManagament.Abnormalities.ContainsKey(name))
            {
                this.unlocked = SaveManagament.Abnormalities[name].unlocked;
                this.department = SaveManagament.Abnormalities[name].department;
                this.researchLevel = SaveManagament.Abnormalities[name].researchLevel;
            }
            else
            {
                this.unlocked = false;
                this.department = Bench.Instance;
                this.researchLevel = 0;
            }
            this.department.abnormalities.Add(this);
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
                this.department.abnormalities.Remove(this);
                this.department = department;
                this.department.abnormalities.Add(this);
            }
        }
        internal virtual void increaseResearchLevel() { }


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
