namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Disciplinary : Department
    {
        public Disciplinary()
        {
            Name = "Disciplinary Team";
            employees = [];
            abnormalities = [];
        }
        internal override void ClerkEffect()
        {
            // todo effect
        }
        internal override void ServiceBenefits(Employee employee)
        {
            // todo effect
        }
    }
}
