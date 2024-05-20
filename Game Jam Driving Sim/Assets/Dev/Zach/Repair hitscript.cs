using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairhitscript : MonoBehaviour
{
    public bool hasHit;
    [SerializeField]
    private PlayerHealthSO playerHealthSO;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

           
            if (hasHit == false)
            {
                playerHealthSO.MyCurrentHealth = playerHealthSO.MyMaxHealth;
                hasHit = true;
            }


        }
    }
}
