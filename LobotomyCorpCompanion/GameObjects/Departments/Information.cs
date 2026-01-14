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
            Employee.GlobalBonuses.SecondaryStats.SR += 5;
        }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.IsCaptain)
            {
                employee.PermanentBonuses.PrimaryStats.Temperance += 10;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.PrimaryStats.Temperance += 7;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.PrimaryStats.Temperance += 5;
            }
            else
            {
                employee.PermanentBonuses.PrimaryStats.Temperance += 3;
            }
        }
    }
}