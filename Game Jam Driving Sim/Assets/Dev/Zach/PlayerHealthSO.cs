using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PlayerHealthSO : ScriptableObject
{

    [SerializeField]
    private float CurrentHealth,MaxHealth;

    public float MyCurrentHealth
    {
        get { return CurrentHealth; }
        set { CurrentHealth = value; }
    }
    public float MyMaxHealth
    {
        get { return MaxHealth; }
        set { MaxHealth = value; }
    }
}
