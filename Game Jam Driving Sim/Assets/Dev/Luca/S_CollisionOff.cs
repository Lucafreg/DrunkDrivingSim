using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_CollisionOff : MonoBehaviour
{

    public bool collisionOff;
    public GameObject collisionBox;
    // Start is called before the first frame update
    void Start()
    {
        collisionOff = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionOff == false)
        {
            
            collisionBox.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            collisionOff = false;
        }
    }
}
