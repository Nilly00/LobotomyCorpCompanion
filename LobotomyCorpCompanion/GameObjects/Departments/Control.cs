namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Control : Department
    {
        // Singleton instance
        private static readonly Control _instance = new();

        // Public accessor
        public static Control Instance => _instance;

        // Private constructor to prevent external instantiation
        private Control() : base(name: "Control"){ }

        internal override void ClerkEffect()
        {
            Employee.GlobalBonuses.SecondaryStats.MS += 5;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.IsCaptain)
            {
                employee.PermanentBonuses.SecondaryStats.MS += 10;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.SecondaryStats.MS += 7;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.SecondaryStats.MS += 5;
            }
            else
            {
                employee.PermanentBonuses.SecondaryStats.MS += 3;
            }
        }
    }
}