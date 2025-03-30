using System.Collections.Generic;

public static class SessionData // Temporary session data, resets itself upon restart
{
    public static int selectedSave = 0; 
    public static int currentArea = -1; // Negative values for testing

    public static int areaType = 1; 
    // 0: out of combat
    // 1: in combat

    public static int currentTurn = 0; 
    // -1: not in combat
    // 0: player
    // 1: enemy

    public static int currentEnergy = 0;
    // -1: not in combat

    public static int selectedSoul = -1;
    // -1: none selected
    
    public static List<string> enemyQueue; // Empty list if out of combat
}
