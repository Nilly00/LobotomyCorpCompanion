namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Safety : Department
    {
        // Singleton instance
        private static readonly Safety _instance = new Safety();

        // Public accessor
        public static Safety Instance => _instance;

        // Private constructor to prevent external instantiation
        private Safety() : base(name: "Safety"){ }

        internal override void ClerkEffect()
        {
            Employee.globalBonuses.HPHealing *= 1.5;
            Employee.globalBonuses.SPHealing *= 1.5;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.permanentBonuses.primaryStats.Fortitude += 10;
                employee.permanentBonuses.primaryStats.Prudence += 10;
            }
            else if (employee.daysInService > 6)
            {
                employee.permanentBonuses.primaryStats.Fortitude += 7;
                employee.permanentBonuses.primaryStats.Prudence += 7;
            }
            else if (employee.daysInService > 2)
            {
                employee.permanentBonuses.primaryStats.Fortitude += 5;
                employee.permanentBonuses.primaryStats.Prudence += 5;
            }
            else
            {
                employee.permanentBonuses.primaryStats.Fortitude += 3;
                employee.permanentBonuses.primaryStats.Prudence += 3;
            }
        }
    }
}