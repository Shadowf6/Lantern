using System.IO;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class GameData
{
    public static int playerHP;
    public static int souls;
    public static List<Soul> playerDeck;
}

public class SaveData : MonoBehaviour
{
    string filePath;

    void Awake()
    {
        filePath = Application.persistentDataPath + "/lantern" + SessionData.selectedSave + ".json";
    }

    void NewDataFile()
    {

    }

    void SaveGame()
    {

    }

    void LoadGame()
    {

    }

    void GetField(string name)
    {

    }
}
