using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script placed on the road to spawn obstacles every generation of a new section of road. In progress
/// </summary>

public class NewBehaviourScript : MonoBehaviour
{
    [Header("Components")]  
    public GameObject[] obstaclesToSpawn;

    [Header("Settings")]
    public float safeDistance = 5f;



    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObjects(int amount)
    {
        for(int i = 0; i < amount; i++)
        {

        }
       

    }

    /// <summary>
    /// Calculates the spawn points for the obstacles and how many can be spawned 
    /// </summary>
    public void CalculateSpawn()
    {
        float roadLength = this.transform.localScale.z;
        float roadWidth = this.transform.localScale.x;


    }
}
