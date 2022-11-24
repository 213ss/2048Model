using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _hight= 4;
    [SerializeField] private int _weight = 4;
    [SerializeField] private Node _nodePrefab;
    [SerializeField] private SpriteRenderer _boardPrefab;
    [SerializeField] private Block _blockPrefab;

    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < _hight; x++)
        {
            for (int y = 0; y < _weight; y++)
            {
                var node = Instantiate(_nodePrefab, new Vector2(x, y), Quaternion.identity);
            }
        }
        var center = new Vector2((float)_weight /2 - 0.5f, (float)_hight /2 - 0.5f);
        var board = Instantiate(_boardPrefab, center, Quaternion.identity);
        board.size = new Vector2(_weight, _hight);
        Camera.main.transform.position = new Vector3(center.x, center.y, -10);
    }
}
