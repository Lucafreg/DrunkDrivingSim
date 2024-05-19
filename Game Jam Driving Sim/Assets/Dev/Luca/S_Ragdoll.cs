using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject manWalking;
    public GameObject manRagdoll;

    public bool hasHit;

    // Start is called before the first frame update
    void Start()
    {
        hasHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasHit == true)
        {
            manWalking.SetActive(false);
            manRagdoll.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hasHit = true;
        }
    }
}
