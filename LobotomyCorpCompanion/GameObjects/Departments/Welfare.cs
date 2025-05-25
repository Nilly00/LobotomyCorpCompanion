namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Welfare : Department
    {
        // Singleton instance
        private static readonly Welfare _instance = new Welfare();

        // Public accessor
        public static Welfare Instance => _instance;

        // Private constructor to prevent external instantiation
        private Welfare() : base(name: "Welfare"){ }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.permanentBonuses.resistances += 0.2;
            }
            else if (employee.daysInService > 6)
            {
                employee.permanentBonuses.resistances += 0.1;
            }
            else if (employee.daysInService > 2)
            {
                employee.permanentBonuses.resistances += 0.06;
            }
            else
            {
                employee.permanentBonuses.resistances += 0.03;
            }
        }
    }
}