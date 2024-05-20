using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class SpeedSO : ScriptableObject
{
    [SerializeField]
    private float playerspeed,playerMaxspeed;

    public float MySpeed
    {
        get { return playerspeed; }
        set { playerspeed = value; }
    }
    public float MyMaxSpeed
    {
        get { return playerMaxspeed; }
        set { playerMaxspeed = value; }
    }
}
