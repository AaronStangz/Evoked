using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{

    ItemManager IM;
    public GameObject mainManger;
    [Space]
    public TMP_Text GoldBars;
    [Space]
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
        IM = mainManger.GetComponent<ItemManager>();
    }

    void Update()
    {
        GoldBars.text = "Gold Bar: " + IM.goldBar + " ";
    }
}
