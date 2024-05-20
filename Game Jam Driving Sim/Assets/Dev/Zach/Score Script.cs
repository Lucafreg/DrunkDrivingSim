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
    [SerializeField]
    private SpeedSO SpeedSO;
    [SerializeField]
    private PlayerHealthSO playerhealthSO;
    private void Awake()
    {
        ScoreGO = GameObject.FindGameObjectWithTag("Player score");
        ScoreText=ScoreGO.GetComponent<TextMeshProUGUI>();
        
    }
    private void Update()
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
            SpeedSO.MyMaxSpeed += .2f;
            
        }
    }
    public void OnHealthUpgrade()
    {
        if(MoneySO.MyScore > 0)
        {
        MoneySO.MyScore -= 100;
            playerhealthSO.MyMaxHealth += 1;
        }
        
    }
    

}
