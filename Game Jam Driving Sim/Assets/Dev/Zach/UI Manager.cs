using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{

    public GameObject UIMAnager;
    public static float CurrentScene;
    public GameObject PlayerHealthUI;
    public Slider PlayerHealthSlider;
    // Start is called before the first frame update
    void Start()
    {
        UIMAnager = GameObject.FindGameObjectWithTag("UIManager");
        PlayerHealthUI = GameObject.FindGameObjectWithTag("PlayerHealthUI");
        PlayerHealthSlider = PlayerHealthUI.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealthSlider.value = Playerhealth.playerHeath;
        
    }
}
