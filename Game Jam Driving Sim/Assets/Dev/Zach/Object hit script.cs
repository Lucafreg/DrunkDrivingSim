using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecthitscript : MonoBehaviour
{
    public bool hasHit;
    [SerializeField]
    private PlayerHealthSO healthSO;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            
            if (hasHit == false)
            {
                healthSO.MyCurrentHealth -= 1;
                hasHit = true;
            }


        }
    }
}
