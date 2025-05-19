namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Bench : Department
    {
        public Bench()
        {
            Name = "Bench";
            employees = new List<Employee>();
        }

        internal override void ClerkEffect(){}
        internal override void ServiceBenefits(Employee employee){}
    }
}
