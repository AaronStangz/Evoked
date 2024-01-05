using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission : MonoBehaviour
{
    MainMenuUI mainMenuUI;
    public GameObject mainMenu;

    public GameObject[] Pages;
    public GameObject PageButtons;
    [Space] 
    public GameObject dailyQuest;
    public GameObject mainMission;
    public GameObject quickPlay;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
            PageButtons.SetActive(false);
        }
    }

    void Start()
    {
        mainMenuUI = mainMenu.GetComponent<MainMenuUI>();
    }

    void Update()
    {
        if (mainMenuUI.OpenMission == true && Input.GetKeyDown(KeyCode.Escape))
        {
            PageButtons.SetActive(true);
            dailyQuest.SetActive(false);
            mainMission.SetActive(false);
            quickPlay.SetActive(false);
        }   
    }
}
