namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Safety : Department
    {
        // Singleton instance
        private static readonly Safety _instance = new();

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
                employee.PermanentBonuses.primaryStats.Fortitude += 10;
                employee.PermanentBonuses.primaryStats.Prudence += 10;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.primaryStats.Fortitude += 7;
                employee.PermanentBonuses.primaryStats.Prudence += 7;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.primaryStats.Fortitude += 5;
                employee.PermanentBonuses.primaryStats.Prudence += 5;
            }
            else
            {
                employee.PermanentBonuses.primaryStats.Fortitude += 3;
                employee.PermanentBonuses.primaryStats.Prudence += 3;
            }
        }
    }
}