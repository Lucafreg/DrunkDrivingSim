using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    public static float playerHeath;
    public float playerStartingHeath;
   
    public bool PlayerDead;
    public bool PlayerInvincibilty;
    public bool InvinciblityTimer;
    public float InvincibilityDurationMax;
    public float InvincibilityDuration;
    
    public void Start()
    {
        playerHeath = playerStartingHeath;
        InvincibilityDuration = InvincibilityDurationMax;   

        
        
    }
    public void FixedUpdate()
    {
        if (playerHeath <= 0)
        {
            PlayerDead = true;
        }
        if (PlayerInvincibilty)
        {
            InvincibilityDuration -= 1;
            
        }
        if (InvincibilityDuration <= 0)
        {
            PlayerInvincibilty = false;
            InvincibilityDuration = InvincibilityDurationMax;
        }
    }

    public void OnPlayerDamage()
    {
        playerHeath -= 1;
        PlayerInvincibilty = true;
    }


}
