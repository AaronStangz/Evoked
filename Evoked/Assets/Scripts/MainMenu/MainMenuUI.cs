using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public GameObject[] Pages;
    public GameObject[] BackGeound;
    public bool OpenMission;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
            BackGeound[i].SetActive(indexToEnable == i);
            if (indexToEnable == 1)
            { OpenMission = true; }
        }
    }

    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
}
