using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{

    public float Score;
    public GameObject ScoreGO;
    public TextMeshProUGUI ScoreText;

    private void Start()
    {
        ScoreGO = GameObject.FindGameObjectWithTag("Player score");
        ScoreText=ScoreGO.GetComponent<TextMeshProUGUI>();
    }
    private void FixedUpdate()
    {
        
        ScoreText.text = ("Score- "+Score);
    }
    public void OnScore()
    {
        Score++;
    }

}
