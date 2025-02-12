using UnityEngine;
using UnityEngine.UI;

public class AssignSoul : MonoBehaviour
{
    GameObject deckBar;

    void Start()
    {
        deckBar = GameObject.FindWithTag("DeckBar");
    }

    public static void AssignStats(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Transform child = deckBar.transform.GetChild(i + 2);
            Image slot = child.GetComponent<Image>();

            if (i < GameData.playerDeck[n].spells.Count)
            {
                slot.sprite = Resources.Load<Sprite>("Sprites/Cards/" + GameData.playerDeck[n].spells[i].name);
                slot.color = Color.white;
            } else
            {
                slot.sprite = null;
                slot.color = new Color(0.5019608f, 0.3254902f, 0.1960784f, 1f);
            }
        }
    }
}
