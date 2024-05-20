using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;

public class PeopleHItScript : MonoBehaviour
{
    public bool hasHit;
    [SerializeField]
    private MoneySO MoneySO;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            print("colided");
            if (hasHit==false)
            {
            MoneySO.MyScore+=1;
                hasHit=true;
            }
            

        }
    }
}
