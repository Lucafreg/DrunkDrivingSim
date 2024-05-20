using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecthitscript : MonoBehaviour
{
    public bool hasHit;
    [SerializeField]
    private PlayerHealthSO healthSO;
    public AudioSource Hitsound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            
            if (hasHit == false)
            {
                Hitsound.Play();
                healthSO.MyCurrentHealth -= 1;
                hasHit = true;
            }


        }
    }
}
