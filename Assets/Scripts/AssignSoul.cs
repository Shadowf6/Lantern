using UnityEngine;
using UnityEngine.UI;

public class AssignSoul : MonoBehaviour
{
    public static void AssignSpells(int n)
    {
        GameObject deckBar = GameObject.FindWithTag("Deck");

        for (int i = 0; i < n; i++)
        {
            GameObject child = deckBar.transform.GetChild(i + 2).gameObject;
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
