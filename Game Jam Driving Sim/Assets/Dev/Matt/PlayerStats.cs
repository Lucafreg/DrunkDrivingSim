using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Player Stats")]
    public float startingHealth;
    public float currentHealth { get; private set; }

    public int startingScore;
    public int currentScore { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitialisePlayerStats()
    {
        currentHealth = startingHealth;
        currentScore = startingScore;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }

    public void AddScore(int score)
    {
        currentScore += score;
    }
}
