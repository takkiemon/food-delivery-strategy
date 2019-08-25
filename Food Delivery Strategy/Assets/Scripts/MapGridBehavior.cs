using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGridBehavior : MonoBehaviour
{
    public GridCell[,] gridMapArray;
    public int mapHeight;
    public int mapWidth;
    public float positionAmplifier;
    public float minimumAmplifier;
    public bool gridIsStanding;

    // Start is called before the first frame update
    void Start()
    {
        DestroyGrid();
        CreateGrid(mapWidth, mapHeight);
        gridIsStanding = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateGrid(int width, int height)
    {
        gridMapArray = new GridCell[mapWidth, mapHeight];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (!gridIsStanding)
                {
                    gridMapArray[x, y] = new GridCell(x, 0, y);
                }
                else
                {
                    gridMapArray[x, y] = new GridCell(x, y);
                }
            }
        }
    }

    public void DestroyGrid()
    {
        gridMapArray = new GridCell[0, 0];
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 1);

        if (positionAmplifier < minimumAmplifier)
        {
            positionAmplifier = minimumAmplifier;
        }
        if (gridMapArray != null && gridMapArray.Length > 0)
        {
            foreach (GridCell cell in gridMapArray)
            {
                Gizmos.DrawWireCube(
                    new Vector3(cell.X * positionAmplifier,
                                cell.Y * positionAmplifier,
                                cell.Z * positionAmplifier),
                    new Vector3(positionAmplifier, positionAmplifier, 0)
                    );
            }
        }
    }
}
