using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridFitting : MonoBehaviour
{
    public float colDif = 0.083f;
    public float rowDif = -0.33f;
    public float initX = -0.455f;
    public float initY = 0.335f;
    public static int width = 12;
    public static int height = 3;
    public static List<List<int>> grid;

    void Start() 
    {
        // Create virtual grid
        grid = new List<List<int>>();
        for (int i = 0; i < height; i++) grid.Add(new List<int>(new int[width]));

        // Handle placing the souls during match start
    }

    public static void AccessibleTiles(int x, int y, int n)
    {
        // (x, y): start from grid[x][y], iterate through direction list
        // n: index of selected soul

        int dx = 0, dy = 0;
        var curr = GameData.playerDeck[n - 1].direction;

        for (int i = 0; i < curr.Count; i++)
        {
            int k = curr[i].Last();

            for (int j = 0; j < curr[i].Length - 1; j++)
            {
                switch (curr[i][j])
                {
                    case 'U':
                        dy += 1; break;
                    case 'D':
                        dy += -1; break;
                    case 'R':
                        dx += 1; break;
                    case 'L':
                        dx += -1; break;
                }
            }

            for (int j = 1; j <= k; j++)
            {
                dx = x + dx * j;
                dy = y + dy * j;

                if (!(dx < 0 || dx >= width || dy < 0 || dy >= height)) // Check for out of bounds
                {
                    grid[dx][dy] = 1; // 1: filled in
                }
            }
        }

        FillTiles();
    }
    
    public static void FillTiles()
    {
        GameObject deckBar = GameObject.FindWithTag("Grid");

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (grid[i][j] == 1)
                {
                    Transform row = deckBar.transform.GetChild(i);
                    Transform col = row.GetChild(j);
                    SpriteRenderer tile = col.GetComponent<SpriteRenderer>();

                    tile.color = new Color(0.6f, 0.6f, 0.6f);
                }
            }
        }
    }

    public static void ResetTiles()
    {
        GameObject deckBar = GameObject.FindWithTag("Grid");

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Transform row = deckBar.transform.GetChild(i);
                GameObject col = row.GetChild(j).gameObject;
                SpriteRenderer tile = col.GetComponent<SpriteRenderer>();

                tile.color = Color.white;
                grid[i][j] = 0;
            }
        }
    }

    public static List<float> MoveToTile(int r, int c)
    {
        return null;
    }
}
