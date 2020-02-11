using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject tile;
    [SerializeField]
    public int sizeX = 5;
    [SerializeField]
    public int sizeY = 5;
    // Use this for initialization
    void Start()
    {
        Vector2 offset = new Vector2((sizeX - 1) / 2f, (sizeY - 1) / 2f);

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                PlaceTile(new Vector2(x, y) - offset, transform, x + "  " + y);
            }
        }
    }

    private void PlaceTile(Vector3 pos, Transform parent, string name)
    {
        GameObject newTile = Instantiate(tile, pos, Quaternion.Euler(0, 0, 360), parent);
        newTile.name = name;
    }
}
