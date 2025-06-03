namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Extraction : Department
    {
        // Singleton instance
        private static readonly Extraction _instance = new();

        // Public accessor
        public static Extraction Instance => _instance;

        // Private constructor to prevent external instantiation
        private Extraction() : base(name: "Extraction"){ }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.isCaptain)
            {
                employee.PermanentBonuses.attackSpeedPercent *= 1.2;
                employee.PermanentBonuses.resistances += 0.2;
            }
            else if (employee.DaysInService > 6)
            {
                employee.PermanentBonuses.attackSpeedPercent *= 1.1;
                employee.PermanentBonuses.resistances += 0.1;
            }
            else if (employee.DaysInService > 2)
            {
                employee.PermanentBonuses.attackSpeedPercent *= 1.06;
                employee.PermanentBonuses.resistances += 0.06;
            }
            else
            {
                employee.PermanentBonuses.attackSpeedPercent *= 1.03;
                employee.PermanentBonuses.resistances += 0.03;
            }
        }
    }
}