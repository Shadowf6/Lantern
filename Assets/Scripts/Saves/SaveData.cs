using System.IO;
using System.Collections.Generic;
using UnityEngine;

public static class GameData // Session-instance data
{
    public static int playerHP;
    public static int coins;
    public static List<Soul> playerDeck = new List<Soul>();
}

[System.Serializable]
public class SerializableData // Serializable class for JSON
{
    public int playerHP;
    public int coins;
    public List<Soul> playerDeck;

    public SerializableData()
    {
        playerHP = GameData.playerHP;
        coins = GameData.coins;
        playerDeck = GameData.playerDeck;
    }

    public void Update()
    {
        GameData.playerHP = playerHP;
        GameData.coins = coins;
        GameData.playerDeck = playerDeck;
    }
}

public class SaveData : MonoBehaviour
{
    string filePath;

    void Start()
    {
        filePath = Application.persistentDataPath + "/lantern" + SessionData.selectedSave + ".json";
    }

    void NewDataFile()
    {
        GameData.playerHP = 100;
        GameData.coins = 0;
        GameData.playerDeck = new List<Soul>();

        SaveGame();
    } 

    public void SaveGame()
    {
        SerializableData data = new SerializableData();

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(filePath, json);
    }

    public void LoadGame()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            SerializableData data = JsonUtility.FromJson<SerializableData>(json);
            data.Update();
        } else
        {
            NewDataFile();
        }
    }
}
