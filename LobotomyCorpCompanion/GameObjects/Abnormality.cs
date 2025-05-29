namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Abnormality
    {
        internal static List<Abnormality> List=
        [
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
        ];


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
            if (SaveManagament.abnoSave.TryGetValue(name, out AbnormalitySave value))
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
        internal virtual void IncreaseResearchLevel() { }
    }

    internal static class AbnormalityManagement
    {
        internal static List<Abnormality> AbnormalityMasterList = [
            Alriune.Instance,
            Apocalypse.Instance,
            Apple.Instance,
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
            Lantern.Instance,
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
            Rabbit.Instance,
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
            WallLady.Instance,
            Wellcheers.Instance,
            White.Instance,
            Wolf.Instance,
            Woodsman.Instance,
            Yin.Instance,
            ];
    }
}
