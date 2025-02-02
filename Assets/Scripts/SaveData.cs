using System.IO;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
class GameData
{
    public int playerHP;
    public int souls;
    public List<Card> playerDeck;
    public List<List<bool>> levelCompletion;
}

public class SaveData : MonoBehaviour
{
    string filePath;

    void Start()
    {
        filePath = Application.persistentDataPath + "/lantern" + SessionData.selectedSave + ".json";
    }

    void NewDataFile() // param: int saveSlot (for later)
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
