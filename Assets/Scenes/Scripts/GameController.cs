using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tile;
    public Vector3 startPoint = new Vector3(0, 0, -5);
    public int initSpawnNumber = 10;
    private Vector3 nextTileLocation;
    private Quaternion nextTileRotation;
    void Start()
    {
        nextTileLocation = startPoint;
        nextTileRotation = Quaternion.identity;

        for (int i = 0; i < initSpawnNumber; i++)
        {
            SpawnNextTile();
        }
        
    }

    public void SpawnNextTile()
    {
        var newTile = Instantiate(tile, nextTileLocation, nextTileRotation);
        var nextTile = newTile.Find("Next Spawn Point");
        nextTileLocation = nextTile.position;
        nextTileRotation = nextTile.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
