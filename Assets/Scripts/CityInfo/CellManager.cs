using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式：管理所有单元格
public class CellManager : MonoBehaviour
{
    private static CellManager _instance;
    private CellManager() { }
    public static CellManager getInstance()
    {
        if (_instance == null)
        {
            GameObject gameObject = new GameObject();
            _instance = gameObject.AddComponent<CellManager>();
            DontDestroyOnLoad(gameObject);
        }
        return _instance;
    }

    private Cell[,] cells;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }

        // 根据子物体的tag，初始化cells数组
        int x_max = 0;
        int y_max = 0;
        foreach (Transform child in transform)
        {
            string[] coordinates = child.tag.Split(',');
            int x = int.Parse(coordinates[0]);
            int y = int.Parse(coordinates[1]);
            x_max = Mathf.Max(x, x_max);
            y_max = Mathf.Max(y, y_max);
        }

        cells = new Cell[x_max + 1, y_max + 1];

        foreach (Transform child in transform)
        {
            Cell cell = child.GetComponent<Cell>();
            if (cell != null)
            {
                string[] coordinates = child.tag.Split(',');
                int x = int.Parse(coordinates[0]);
                int y = int.Parse(coordinates[1]);
                cells[x, y] = cell;
            }
        }
    }

    // 中介者模式：将单元格之间的距离计算委托给CellManager
    // CellManager作为Cell的Mediator
    public List<Cell> getNeighborCells(Cell cell, int distance)
    {
        List<Cell> neighborCells = new List<Cell>();
        int x = cell.x;
        int y = cell.y;
        for (int i = x - distance; i <= x + distance; i++)
        {
            for (int j = y - distance; j <= y + distance; j++)
            {
                if (i >= 0 && i < cells.GetLength(0) && j >= 0 && j < cells.GetLength(1))
                {
                    neighborCells.Add(cells[i, j]);
                }
            }
        }
        return neighborCells;
    }
}
