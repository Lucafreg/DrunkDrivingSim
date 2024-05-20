using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Generates the obstacles along the road 
/// </summary>
public class RoadGeneration : MonoBehaviour
{
    public GameObject[] RoadObstacles;
    public GameObject[] Characters;
    public GameObject PowerUp;
    public int PowerUpSpawnChance;
    public List<Transform> characterCrossingPoints;
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
        
        for(int i = 0; i < characterCrossingPoints.Count;++i)
        {
            GameObject go = Instantiate(Characters[Random.Range(0, Characters.Length)], characterCrossingPoints[i].position, Quaternion.identity);
            positions.Add(characterCrossingPoints[i].position);
            go.transform.SetParent(transform);
            S_NPC_Walk s_NPC_Walk = go.GetComponent<S_NPC_Walk>();
            if (characterCrossingPoints[i].position.x < transform.position.x)
            {
                
                s_NPC_Walk.direction = Vector3.right;
            }
            else if (characterCrossingPoints[i].position.x > transform.position.x)
            { 
                s_NPC_Walk.direction = Vector3.left;

            }

        }
        
        int powerUpChance = Random.Range(0, 100);
        if(powerUpChance < PowerUpSpawnChance)
        {
            Vector3 spawnPos = GeneratePosition();
            GameObject go = Instantiate(PowerUp, spawnPos, Quaternion.identity);
            positions.Add(spawnPos);
            go.transform.SetParent(transform);
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
