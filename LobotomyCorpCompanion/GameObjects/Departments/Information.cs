namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Information : Department
    {
        // Singleton instance
        private static readonly Information _instance = new();

        // Public accessor
        public static Information Instance => _instance;

        // Private constructor to prevent external instantiation
        private Information() : base(name: "Information"){ }

        internal override void ClerkEffect()
        {
            Employee.globalBonuses.secondaryStats.SR += 5;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.PermanentBonuses.primaryStats.Temperance += 10;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.primaryStats.Temperance += 7;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.primaryStats.Temperance += 5;
            }
            else
            {
                employee.PermanentBonuses.primaryStats.Temperance += 3;
            }
        }
    }
}