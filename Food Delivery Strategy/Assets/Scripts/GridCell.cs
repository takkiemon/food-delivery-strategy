using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCell
{
    public int X;
    public int Y;
    public int Z;
    public bool cellIsStanding;

    public GridCell()
    {
        X = -1;
        Y = -1;
        Z = 0;
    }

    public GridCell(int x, int y)
    {
        X = x;
        Y = y;
        Z = 0;
    }

    public GridCell(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
