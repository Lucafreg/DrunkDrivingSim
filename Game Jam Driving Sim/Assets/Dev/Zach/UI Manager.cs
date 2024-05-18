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
    public GameObject MainMenuUI;
    public GameObject PauseMenuUI, CreditsMenuUI;

    public bool Resumed;
    private void Awake()
    {
        CreditsMenuUI.SetActive(false);
        PauseMenuUI.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        UIMAnager = GameObject.FindGameObjectWithTag("UIManager");
        PlayerHealthUI = GameObject.FindGameObjectWithTag("PlayerHealthUI");
        //PlayerHealthSlider = PlayerHealthUI.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerHealthSlider.value = Playerhealth.playerHeath;
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Resumed)
         {
            OnPause();
         }
            else
            {
                OnResume();
            }
        }
    }
    public void OnPlay()
    {
        MainMenuUI.SetActive(false);
    }
    public void OnPause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = .0f;
    }
    public void OnResume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OnCredits()
    {
        CreditsMenuUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }
    public void OnMainMenuPause()
    {
        MainMenuUI.SetActive(true);
        PauseMenuUI.SetActive(false);
        Time.timeScale = .0f;
    }
    public void OnMainMenuCredits()
    {
        MainMenuUI.SetActive(true);
        CreditsMenuUI.SetActive(false);
    }
    public void OnQuit()
    {
        Application.Quit();
    }
}
