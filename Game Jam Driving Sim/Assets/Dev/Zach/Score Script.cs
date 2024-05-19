using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{

    public float Score, Money;
    public GameObject ScoreGO;
    public TextMeshProUGUI ScoreText;

    [SerializeField]
    private MoneySO MoneySO;
    
    private void Awake()
    {
        ScoreGO = GameObject.FindGameObjectWithTag("Player score");
        ScoreText=ScoreGO.GetComponent<TextMeshProUGUI>();
        
    }
    private void FixedUpdate()
    {
        
        ScoreText.text = ("Money- "+ MoneySO.MyScore);
       
    }
    public void OnScore()
    {
        MoneySO.MyScore++;
    }
    public void OnCashOut()
    {
       
    }

    public void OnSpeedUpgrade()
    {
        if (MoneySO.MyScore > 0)
        {
            MoneySO.MyScore -= 50;
        }
    }
    public void OnHealthUpgrade()
    {
        if(MoneySO.MyScore > 0)
        {
        MoneySO.MyScore -= 100;
        }
        
    }
    

}
