namespace LobotomyCorpCompanion.GameObjects.Departments
{
    internal sealed class Bench : Department
    {
        // Singleton instance
        private static readonly Bench _instance = new Bench();

        // Public accessor
        public static Bench Instance => _instance;

        // Private constructor to prevent external instantiation
        private Bench() : base(name: "Bench",employeeCap: -1,abnormalityCap: -1){ }


    }
}