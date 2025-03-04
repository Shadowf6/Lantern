using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FightSequence : MonoBehaviour
{
    public Button endTurnButton;
    public TextMeshProUGUI turnText, energyText;
    int turnNum = 0;

    void Start()
    {
        GameData.playerDeck.Add(Defaults.MakeSoul("Lantern"));
        SessionData.currentTurn = 0;
        PlaceSouls();
    }

    void PlaceSouls()
    {
        PlayerTurn();
    }

    void PlayerTurn()
    {
        turnNum++;

        endTurnButton.gameObject.SetActive(true);
        turnText.text = "Your Turn";

        SessionData.currentEnergy += 3; // Player will gain more energy as more turns progress
        energyText.text = SessionData.currentEnergy.ToString();

        endTurnButton.onClick.RemoveAllListeners();
        endTurnButton.onClick.AddListener(HideButton);
    }

    void HideButton()
    {
        SessionData.currentTurn = 1;
        turnText.text = "";
        EnemyTurn();
        endTurnButton.gameObject.SetActive(false);
    }

    void EnemyTurn()
    {
        SessionData.currentTurn = 0;

        // enemy attack

        StartCoroutine(Sleep());
    }

    IEnumerator Sleep() // remove later
    {
        yield return new WaitForSeconds(3f);
        SessionData.currentTurn = 0;
        PlayerTurn();
    }
}
