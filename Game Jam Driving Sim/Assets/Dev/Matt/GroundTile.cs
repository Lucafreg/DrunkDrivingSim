
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
        groundSpawn.Spawn();
        Destroy(gameObject, 2);
        Debug.Log("Destroyed Tile");
    }
}
