namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Training : Department
    {
        // Singleton instance
        private static readonly Training _instance = new();

        // Public accessor
        public static Training Instance => _instance;

        // Private constructor to prevent external instantiation
        private Training() : base(name: "Training"){ }

        internal override void ServiceBenefits(Employee employee)
        {
            if (employee.IsCaptain)
            {
                employee.PermanentBonuses.PrimaryStats += 4;
            }
        }
    }
}