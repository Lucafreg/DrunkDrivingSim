using UnityEngine;

public class GroundSpawn : MonoBehaviour
{

    public GameObject ground;
    Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
      for(int i = 0; i < 4; i++)
       {
        Spawn();
      }
    }


    public void Spawn()
    {
      GameObject tmp = Instantiate(ground, nextSpawnPoint, Quaternion.identity);
      Vector3 childPos = tmp.transform.GetChild(0).GetChild(8).transform.position;
        nextSpawnPoint = new Vector3(nextSpawnPoint.x,nextSpawnPoint.y,childPos.z);
        //Debug.Log(nextSpawnPoint);
    }
  
}
