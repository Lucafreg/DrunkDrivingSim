using UnityEngine;

public class GroundSpawn : MonoBehaviour
{

    public GameObject ground;
    Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
       Spawn();
        Spawn();
        Spawn();
        Spawn();
       
    }


    public void Spawn()
    {
      GameObject tmp = Instantiate(ground, nextSpawnPoint, Quaternion.identity);
       nextSpawnPoint = tmp.transform.GetChild(0).GetChild(8).transform.position;
        Debug.Log(nextSpawnPoint);
    }
  
}
