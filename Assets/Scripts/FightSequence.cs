using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FightSequence : MonoBehaviour
{
    public Button endTurnButton;
    public TextMeshProUGUI turnText;
    int playerHP;
    int enemyHP;

    void Start()
    {
        SessionData.currentTurn = 0;
        PlayerTurn();
    }

    public void PlayerTurn()
    {
        endTurnButton.gameObject.SetActive(true);
        SessionData.currentTurn = 1;
        turnText.text = "Your turn";

        endTurnButton.onClick.AddListener(HideButton);
    }

    void HideButton()
    {
        EnemyTurn();
        endTurnButton.gameObject.SetActive(false);
    }

    public void EnemyTurn()
    {
        endTurnButton.gameObject.SetActive(false);
        SessionData.currentTurn = 0;
        turnText.text = "";

        // EnemyAttack() for e in enemy

        StartCoroutine(Sleep());
        PlayerTurn();
    }

    IEnumerator Sleep()
    {
        yield return new WaitForSeconds(1f);
    }
}
