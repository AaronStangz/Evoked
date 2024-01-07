using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Armory : MonoBehaviour
{
    ItemManager IM;
    public GameObject mainManger;
    [Space]
    public GameObject[] Pages;
    [Space]
    public GameObject[] Sidebar;
    [Space]
    public GameObject[] MainGuns;
    public GameObject[] SecondGuns;
    [Space]
    public TMP_Text[] TextMain;
    public TMP_Text[] TextSecond;
    [Space]
    public GameObject[] EquipedUIMain;
    public GameObject[] EquipedUISecond;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleSidebar(int indexToEnable)
    {
        for (int i = 0; i < Sidebar.Length; i++)
        {
            Sidebar[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleEquipedUIMain(int indexToEnable)
    {
        for (int i = 0; i < EquipedUIMain.Length; i++)
        {
            EquipedUIMain[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleEquipedUISecond(int indexToEnable)
    {
        for (int i = 0; i < EquipedUISecond.Length; i++)
        {
            EquipedUISecond[i].SetActive(indexToEnable == i);
        }
    }

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
    }

    void Update()
    {
        ResearchPartsTexts();
    }

    public void ResearchPartsTexts()
    {
        TextMain[0].text = "Weapon Level: " + IM.eclipseEnforcerLevel + " " ;
        TextMain[1].text = "Weapon Level: " + IM.phantomWhisperLevel + " ";
        TextMain[2].text = "Weapon Level: " + IM.cobaltSentinelLevel + " ";
        TextMain[3].text = "Weapon Level: " + IM.zenithDefenderLevel + " ";
        TextMain[4].text = "Weapon Level: " + IM.emberGuardianLevel + " ";
        TextMain[5].text = "Weapon Level: " + IM.nebulaHavocLevel + " ";

        TextSecond[0].text = "Weapon Level: " + IM.eclipseEnforcerLevel + " ";
        TextSecond[1].text = "Weapon Level: " + IM.phantomWhisperLevel + " ";
        TextSecond[2].text = "Weapon Level: " + IM.cobaltSentinelLevel + " ";
        TextSecond[3].text = "Weapon Level: " + IM.zenithDefenderLevel + " ";
        TextSecond[4].text = "Weapon Level: " + IM.emberGuardianLevel + " ";
        TextSecond[5].text = "Weapon Level: " + IM.nebulaHavocLevel + " ";
    }

    public void EclipseEnforcerMain()
    {
        MainGuns[0].SetActive(true);
    }

    public void PhantomWhisperMain()
    {
        MainGuns[1].SetActive(true);
    }

    public void ChcobaltSentinelMain()
    {
        MainGuns[2].SetActive(true);
    }

    public void ZenithDefenderMain()
    {
        MainGuns[3].SetActive(true);
    }

    public void EmberGuardianMain()
    {
        MainGuns[4].SetActive(true);
    }

    public void NebulaHavocPartsMain()
    {
        MainGuns[5].SetActive(true);
    }




    public void EclipseEnforcerSecond()
    {
        SecondGuns[0].SetActive(true);
    }

    public void PhantomWhisperSecond()
    {
        SecondGuns[1].SetActive(true);
    }

    public void ChcobaltSentinelSecond()
    {
        SecondGuns[2].SetActive(true);
    }

    public void ZenithDefenderSecond()
    {
        SecondGuns[3].SetActive(true);
    }

    public void EmberGuardianSecond()
    {
        SecondGuns[4].SetActive(true);
    }

    public void NebulaHavocPartsSecond()
    {
        SecondGuns[5].SetActive(true);
    }
}
