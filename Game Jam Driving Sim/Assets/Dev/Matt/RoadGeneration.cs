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
    public float minDistanceBetweenObjects;
    public float roadLength;
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
        float startZ = roadLength / 4;
        float endZ = roadLength;
        for(int i = 0; i <numberOfObstacles;i++)
        {
           Vector3 spawnPos = GeneratePosition();
            bool validPos = true;

            if(!positions.Contains(spawnPos))
            {
                GameObject go = Instantiate(RoadObstacles[Random.Range(0, RoadObstacles.Length)], spawnPos, Quaternion.identity);
                go.transform.SetParent(transform);
                positions.Add(spawnPos);
            }

            
        }
    }

    public Vector3 GeneratePosition()
    {
        float xPos;
        float zPos;
        Vector3 spawnPos;
        do
        {
            xPos = Random.Range(transform.position.x - 1, transform.position.x + 1);
            zPos = Random.Range(transform.position.z, transform.position.z + 35);
            spawnPos = new Vector3(xPos, 0, zPos);
        } while (xPos < minDistanceBetweenObjects && zPos < minDistanceBetweenObjects);
        
        return spawnPos;
    }
   
   
}
