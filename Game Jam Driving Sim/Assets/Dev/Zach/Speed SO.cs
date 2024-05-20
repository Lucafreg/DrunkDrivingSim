using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class SpeedSO : ScriptableObject
{
    [SerializeField]
    private float playerspeed;

    public float MySpeed
    {
        get { return playerspeed; }
        set { playerspeed = value; }
    }

}
