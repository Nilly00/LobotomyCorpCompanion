namespace LobotomyCorpCompanion.GameObjects
{
    public enum DamageType
    {
        //standard
        RED,
        WHITE,
        BLACK,
        PALE,
        //special reserved
        HEALING,
        BLACK_WHITE,
        SPECIAL,
    }

    public enum RiskLevel
    {
        ZAYIN   = 0,
        TETH    = 1,
        HE      = 2,
        WAW     = 3,
        ALEPH   = 4,
    }

    public static class RiskLevelExtensions
    {
        public static double RiskMultiplier(this RiskLevel attacker, RiskLevel defender)
        {
            double[,] multiplierTable = {
            {1.0,   1.0,    1.2,    1.5,    2.0},
            {0.8,   1.0,    1.0,    1.2,    1.5},
            {0.7,   0.8,    1.0,    1.9,    1.2},
            {0.6,   0.7,    0.8,    1.0,    1.0},
            {0.4,   0.6,    0.7,    0.8,    1.0}
            };
            return multiplierTable[(int)defender, (int)attacker];
        }
    }
}