using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoneySO : ScriptableObject
{
    [SerializeField]
    private float Money;

        public float MyMoney
    {
        get { return Money; }
        set { Money = value; }
    }

    [SerializeField]
    private float Score ;

    public float MyScore
    {
        get { return Score ; }
        set { Score = value; }
    }
}
