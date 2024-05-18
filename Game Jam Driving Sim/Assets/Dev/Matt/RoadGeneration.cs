using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generates the obstacles along the road 
/// </summary>
public class RoadGeneration : MonoBehaviour
{
    public GameObject[] RoadObstacles;
    public int numberOfObstacles;
    public float minYDistanceBetweenObjects;
    private List<Vector3> positions = new();
    // Start is called before the first frame update
    void Start()
    {
       
       Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Spawn()
    {
        for(int i = 0; i <numberOfObstacles;i++)
        {
            GameObject go = Instantiate(RoadObstacles[Random.Range(0, RoadObstacles.Length)], transform.position, Quaternion.identity);
        }
    }
   
}
