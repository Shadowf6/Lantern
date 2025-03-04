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
                grid[x + dx * j][y + dy * j] = 1;
            }
        }
    } 

    public static void ResetTiles()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                grid[i][j] = 0;
            }
        }
    }

    public static List<float> MoveToTile()
    {
        return null;
    }
}
