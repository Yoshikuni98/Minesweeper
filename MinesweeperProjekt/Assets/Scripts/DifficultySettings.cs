using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySettings
{
    int rows;
    int col;
    int mineCounter;
    float camX;
    float camY;

    public DifficultySettings(int _rows, int _col, int _mineCounter, float _camX, float _camY)
    {
        rows = _rows;
        col = _col;
        mineCounter = _mineCounter;
        camX = _camX;
        camY = _camY;
    }

    public int GetRows()
    {
        return rows;
    }
    public int GetCol()
    {
        return col;
    }
    public int GetMineCount()
    {
        return mineCounter;
    }
    public float GetCamX()
    {
        return camX;
    }
    public float GetCamY()
    {
        return camY;
    }
}
