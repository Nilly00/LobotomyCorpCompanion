namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Welfare : Department
    {
        // Singleton instance
        private static readonly Welfare _instance = new();

        // Public accessor
        public static Welfare Instance => _instance;

        // Private constructor to prevent external instantiation
        private Welfare() : base(name: "Welfare"){ }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.PermanentBonuses.resistances += 0.2;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.resistances += 0.1;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.resistances += 0.06;
            }
            else
            {
                employee.PermanentBonuses.resistances += 0.03;
            }
        }
    }
}