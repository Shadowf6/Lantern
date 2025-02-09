using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FightSequence : MonoBehaviour
{
    public Button endTurnButton;
    public TextMeshProUGUI turnText;
    public TextMeshProUGUI energyText;
    int turn = 0;

    void Start()
    {
        SessionData.currentTurn = 0;
        PlayerTurn();
    }

    public void PlayerTurn()
    {
        turn++;

        endTurnButton.gameObject.SetActive(true);
        turnText.text = "Your Turn";

        SessionData.currentEnergy += 3;
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

    public void EnemyTurn()
    {
        SessionData.currentTurn = 0;

        // enemy attack

        StartCoroutine(Sleep());
    }

    IEnumerator Sleep()
    {
        yield return new WaitForSeconds(3f);
        SessionData.currentTurn = 0;
        PlayerTurn();
    }
}
