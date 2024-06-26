using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject UIMAnager;
    public int MainMenuScene,GameScene;
    public GameObject PlayerHealthUI;
    public UnityEngine.UI.Slider PlayerHealthSlider;
    public GameObject MainMenuUI;
    public GameObject PauseMenuUI, CreditsMenuUI, LoseMenuUI;

    [SerializeField]
    private PlayerHealthSO playerhealthSO;

    [SerializeField]
    private SpeedSO speedSO;
    [SerializeField]
    private MoneySO moneySo;



    public bool Resumed;
    private void Awake()
    {
        CreditsMenuUI.SetActive(false);
        PauseMenuUI.SetActive(false);
        LoseMenuUI.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        UIMAnager = GameObject.FindGameObjectWithTag("UIManager");
        PlayerHealthUI = GameObject.FindGameObjectWithTag("PlayerHealthUI");
        PlayerHealthSlider = PlayerHealthUI.GetComponent<UnityEngine.UI.Slider>();
        Resumed = true;
        MainMenuScene = 0;
        GameScene = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerHealthSlider.maxValue = playerhealthSO.MyMaxHealth;
        PlayerHealthSlider.value = playerhealthSO.MyCurrentHealth;
        
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
       
        if(PlayerHealthSlider.value <= 0)
        {
            OnLose();
        }
    }
    public void OnPlay()
    {
        
        SceneManager.LoadScene(GameScene);
        playerhealthSO.MyCurrentHealth = playerhealthSO.MyMaxHealth;
        Time.timeScale = 1f;
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
    public void OnRepair()
    {
        playerhealthSO.MyCurrentHealth+=1 ;
    }
    public void OnSpeedboost()
    {

    }
    public void OnCredits()
    {
        CreditsMenuUI.SetActive(true);
        MainMenuUI.SetActive(false);
    }
    public void OnMainMenu()
    {
        
        SceneManager.LoadScene(MainMenuScene);
        Time.timeScale = 1f;
    }
    public void OnMainMenuCredits()
    {
        MainMenuUI.SetActive(true);
        CreditsMenuUI.SetActive(false);
    }
    public void OnLose()
    {
        LoseMenuUI.SetActive(true);
        Resumed = false;
        Time.timeScale = 0f;

    }
    
    public void OnQuit()
    {
        Application.Quit();
    }
}
