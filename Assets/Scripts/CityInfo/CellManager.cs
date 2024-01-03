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

    float cell_size = 2.56f;

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
        int x_min = int.MaxValue;
        int y_min = int.MaxValue;
        int x_max = int.MinValue;
        int y_max = int.MinValue;

        foreach (Transform child in transform)
        {
            Vector3 position = child.position;
            int x = Mathf.RoundToInt(position.x / cell_size);
            int y = Mathf.RoundToInt(position.y / cell_size);
            x_min = Mathf.Min(x, x_min);
            y_min = Mathf.Min(y, y_min);
            x_max = Mathf.Max(x, x_max);
            y_max = Mathf.Max(y, y_max);
        }

        int width = x_max - x_min + 1;
        int height = y_max - y_min + 1;
        cells = new Cell[width, height];

        foreach (Transform child in transform)
        {
            Cell cell = child.GetComponent<Cell>();
            if (cell != null)
            {
                Vector3 position = child.position;
                int x = Mathf.RoundToInt(position.x / cell_size) - x_min;
                int y = Mathf.RoundToInt(position.y / cell_size) - y_min;
                cells[x, y] = cell;
                cell.x = x;
                cell.y = y;
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

    // 所有单元格恢复原色
    public void AllResetColor()
    {
        foreach (Cell cell in cells)
        {
            cell.ResetColor();
        }
    }
}
