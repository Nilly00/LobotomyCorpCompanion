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
            Employee.GlobalBonuses.HPHealing *= 1.5;
            Employee.GlobalBonuses.SPHealing *= 1.5;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.IsCaptain)
            {
                employee.PermanentBonuses.PrimaryStats.Fortitude += 10;
                employee.PermanentBonuses.PrimaryStats.Prudence += 10;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.PrimaryStats.Fortitude += 7;
                employee.PermanentBonuses.PrimaryStats.Prudence += 7;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.PrimaryStats.Fortitude += 5;
                employee.PermanentBonuses.PrimaryStats.Prudence += 5;
            }
            else
            {
                employee.PermanentBonuses.PrimaryStats.Fortitude += 3;
                employee.PermanentBonuses.PrimaryStats.Prudence += 3;
            }
        }
    }
}