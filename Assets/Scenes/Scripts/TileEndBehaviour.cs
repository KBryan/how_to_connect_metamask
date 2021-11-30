using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileEndBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float destroyTime = 1.5f;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.GetComponent<PlayerBehaviour>())
        {
            GameObject.FindObjectOfType<GameController>().SpawnNextTile();
            Destroy(transform.parent.gameObject, destroyTime);
        }
    }
}
