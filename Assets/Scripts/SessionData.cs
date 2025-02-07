using System.Collections.Generic;

public static class SessionData
{
    public static int selectedSave = 0; // -1 if in menu
    public static int currentArea = -1; // Negative values for testing
    public static int areaType = 1; // 0: out of combat, 1: in combat

    public static int currentTurn = 0; // -1 if not in combat, 0 if player, 1 if enemy
    public static int currentEnergy = 6; // -1 if not in combat
    public static List<string> enemyQueue; // Empty list if out of combat
}
