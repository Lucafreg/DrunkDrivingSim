using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawn groundSpawn;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawn = GameObject.FindFirstObjectByType<GroundSpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player has exited the tile");
            groundSpawn.Spawn();
            Destroy(gameObject, 3f);
            Debug.Log("Destroyed Tile after delay");
        }
        
       
    }
}
