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
    public TMP_Text[] PartsText;
    public TMP_Text[] LevelText;
    public TMP_Text[] GunXPText;
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
        PartsText[0].text = "Parts: " + IM.eclipseEnforcerParts + " / " + IM.eclipseEnforcerPartsNeeded + " ";
        PartsText[1].text = "Parts: " + IM.phantomWhisperParts + " / " + IM.phantomWhisperPartsNeeded + " ";
        PartsText[2].text = "Parts: " + IM.cobaltSentinelParts + " / " + IM.cobaltSentinelPartsNeeded + " ";
        PartsText[3].text = "Parts: " + IM.zenithDefenderParts + " / " + IM.zenithDefenderPartsNeeded + " ";
        PartsText[4].text = "Parts: " + IM.emberGuardianParts + " / " + IM.emberGuardianPartsNeeded + " ";
        PartsText[5].text = "Parts: " + IM.nebulaHavocParts + " / " + IM.nebulaHavocPartsNeeded + " ";

        LevelText[0].text = "Weapon Level: " + IM.eclipseEnforcerLevel + " ";
        LevelText[1].text = "Weapon Level: " + IM.phantomWhisperLevel + " ";
        LevelText[2].text = "Weapon Level: " + IM.cobaltSentinelLevel + " ";
        LevelText[3].text = "Weapon Level: " + IM.zenithDefenderLevel + " ";
        LevelText[4].text = "Weapon Level: " + IM.emberGuardianLevel + " ";
        LevelText[5].text = "Weapon Level: " + IM.nebulaHavocLevel + " ";

        GunXPText[0].text = "Gun Xp: " + IM.gunXp + " / " + IM.eclipseEnforcerGunXP + " "; ;
        GunXPText[1].text = "Gun Xp: " + IM.gunXp + " / " + IM.phantomWhisperGunXP + " "; ;
        GunXPText[2].text = "Gun Xp: " + IM.gunXp + " / " + IM.cobaltSentinelGunXP + " ";
        GunXPText[3].text = "Gun Xp: " + IM.gunXp + " / " + IM.zenithDefenderGunXP + " ";
        GunXPText[4].text = "Gun Xp: " + IM.gunXp + " / " + IM.emberGuardianGunXP + " "; ;
        GunXPText[5].text = "Gun Xp: " + IM.gunXp + " / " + IM.nebulaHavocGunXP + " "; ;
    }

    public void ResearchEclipseEnforcer()
    {
        if(IM.eclipseEnforcerParts >= IM.eclipseEnforcerPartsNeeded && IM.gunXp >= IM.eclipseEnforcerGunXP)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[0]);
            Destroy(SecondLocks[0]);
            IM.eclipseEnforcerParts -= IM.eclipseEnforcerPartsNeeded;
            IM.gunXp -= IM.eclipseEnforcerGunXP;
            IM.eclipseEnforcerPartsNeeded += 5;
            IM.eclipseEnforcerLevel += 1;
            IM.eclipseEnforcerGunXP += 100;
            IM.xp += 50;
        }
    }

    public void ResearchPhantomWhisper()
    {
        if (IM.phantomWhisperParts >= IM.phantomWhisperPartsNeeded && IM.gunXp >= IM.phantomWhisperGunXP)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[1]);
            Destroy(SecondLocks[1]);
            IM.phantomWhisperParts -= IM.phantomWhisperPartsNeeded;
            IM.gunXp -= IM.phantomWhisperGunXP;
            IM.phantomWhisperPartsNeeded += 5;
            IM.phantomWhisperLevel += 1;
            IM.phantomWhisperGunXP += 100;
            IM.xp += 50;
        }
    }

    public void ResearChcobaltSentinel()
    {
        if (IM.cobaltSentinelParts >= IM.cobaltSentinelPartsNeeded && IM.gunXp >= IM.cobaltSentinelGunXP)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[2]);
            Destroy(SecondLocks[2]);
            IM.cobaltSentinelParts -= IM.cobaltSentinelPartsNeeded;
            IM.gunXp -= IM.cobaltSentinelGunXP;
            IM.cobaltSentinelPartsNeeded += 5;
            IM.cobaltSentinelLevel += 1;
            IM.cobaltSentinelGunXP += 100;
            IM.xp += 50;
        }
    }

    public void ResearchZenithDefender()
    {
        if (IM.zenithDefenderParts >= IM.zenithDefenderPartsNeeded && IM.gunXp >= IM.zenithDefenderGunXP)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[3]);
            Destroy(SecondLocks[3]);
            IM.zenithDefenderParts -= IM.zenithDefenderPartsNeeded;
            IM.gunXp -= IM.zenithDefenderGunXP;
            IM.zenithDefenderPartsNeeded += 5;
            IM.zenithDefenderLevel += 1;
            IM.zenithDefenderGunXP += 100;
            IM.xp += 50;
        }
    }
    public void ResearchEmberGuardian()
    {
        if (IM.emberGuardianParts >= IM.emberGuardianPartsNeeded && IM.gunXp >= IM.emberGuardianGunXP)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[4]);
            Destroy(SecondLocks[4]);
            IM.emberGuardianParts -= IM.emberGuardianPartsNeeded;
            IM.gunXp -= IM.emberGuardianGunXP;
            IM.emberGuardianPartsNeeded += 5;
            IM.emberGuardianLevel += 1;
            IM.emberGuardianGunXP += 100;
            IM.xp += 50;
        }
    }
    public void ResearchNebulaHavoc()
    {
        if (IM.nebulaHavocParts >= IM.nebulaHavocPartsNeeded && IM.gunXp >= IM.nebulaHavocGunXP)
        {
            Debug.Log("ReSearched");
            Destroy(MainLocks[5]);
            Destroy(SecondLocks[5]);
            IM.nebulaHavocParts -= IM.nebulaHavocPartsNeeded;
            IM.gunXp -= IM.nebulaHavocGunXP;
            IM.nebulaHavocPartsNeeded += 5;
            IM.nebulaHavocLevel += 1;
            IM.nebulaHavocGunXP += 100;
            IM.xp += 50;
        }
    }
}
