namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal class Welfare : Department
    {
        public Welfare()
        {
            Name = "Welfare Team";
            employees = new List<Employee>();
            abnormalities = new List<AbnormalityOld>();
        }
        internal override void ServiceBenefits(Employee employee)
        {
            //todo figure out how the defense increase works
        }
    }
}
