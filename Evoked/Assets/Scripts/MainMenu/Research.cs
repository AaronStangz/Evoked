using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Research : MonoBehaviour
{
    ItemManager IM;
    public GameObject mainManger;
    [Space]
    public GameObject[] Pages; 
    public GameObject[] Sidebar;
    [Space]
    public TMP_Text[] Text;
    public GameObject[] MainLocks;
    public GameObject[] SecondLocks;


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
        Text[0].text = "Parts: " + IM.eclipseEnforcerParts + " / " + IM.eclipseEnforcerPartsNeeded + " ";
        Text[1].text = "Parts: " + IM.phantomWhisperParts + " / " + IM.phantomWhisperPartsNeeded + " ";
        Text[2].text = "Parts: " + IM.cobaltSentinelParts + " / " + IM.cobaltSentinelPartsNeeded + " ";
        Text[3].text = "Parts: " + IM.zenithDefenderParts + " / " + IM.zenithDefenderPartsNeeded + " ";
        Text[4].text = "Parts: " + IM.emberGuardianParts + " / " + IM.emberGuardianPartsNeeded + " ";
        Text[5].text = "Parts: " + IM.nebulaHavocParts + " / " + IM.nebulaHavocPartsNeeded + " ";
    }

    public void ResearchEclipseEnforcer()
    {
        if(IM.eclipseEnforcerParts >= IM.eclipseEnforcerPartsNeeded)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[0]);
            Destroy(SecondLocks[0]);
            IM.eclipseEnforcerParts -= IM.eclipseEnforcerPartsNeeded;
            IM.eclipseEnforcerPartsNeeded += 5;
            IM.eclipseEnforcerLevel += 1;
            IM.xp += 50;
        }
    }

    public void ResearchPhantomWhisper()
    {
        if (IM.phantomWhisperParts >= IM.phantomWhisperPartsNeeded)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[1]);
            Destroy(SecondLocks[1]);
            IM.phantomWhisperParts -= IM.phantomWhisperPartsNeeded;
            IM.phantomWhisperPartsNeeded += 5;
            IM.phantomWhisperLevel += 1;
            IM.xp += 50;
        }
    }

    public void ResearChcobaltSentinel()
    {
        if (IM.cobaltSentinelParts >= IM.cobaltSentinelPartsNeeded)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[2]);
            Destroy(SecondLocks[2]);
            IM.cobaltSentinelParts -= IM.cobaltSentinelPartsNeeded;
            IM.cobaltSentinelPartsNeeded += 5;
            IM.cobaltSentinelLevel += 1;
            IM.xp += 50;
        }
    }

    public void ResearchZenithDefender()
    {
        if (IM.zenithDefenderParts >= IM.zenithDefenderPartsNeeded)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[3]);
            Destroy(SecondLocks[3]);
            IM.zenithDefenderParts -= IM.zenithDefenderPartsNeeded;
            IM.zenithDefenderPartsNeeded += 5;
            IM.zenithDefenderLevel += 1;
            IM.xp += 50;
        }
    }
    public void ResearchEmberGuardian()
    {
        if (IM.emberGuardianParts >= IM.emberGuardianPartsNeeded)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[4]);
            Destroy(SecondLocks[4]);
            IM.emberGuardianParts -= IM.emberGuardianPartsNeeded;
            IM.emberGuardianPartsNeeded += 5;
            IM.emberGuardianLevel += 1;
            IM.xp += 50;
        }
    }
    public void ResearchNebulaHavoc()
    {
        if (IM.nebulaHavocParts >= IM.nebulaHavocPartsNeeded)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[5]);
            Destroy(SecondLocks[5]);
            IM.nebulaHavocParts -= IM.nebulaHavocPartsNeeded;
            IM.nebulaHavocPartsNeeded += 5;
            IM.nebulaHavocLevel += 1;
            IM.xp += 50;
        }
    }
}
