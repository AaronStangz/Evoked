using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Locker : MonoBehaviour
{
    ItemManager IM;
    public GameObject mainManger;
    [Space]
    public GameObject[] Pages;
    public GameObject[] HerosSidebar;
    public GameObject[] StorgeSidebar;
    public GameObject[] Heros;
    public TMP_Text[] Text;
    public TMP_Text[] CraftAmmoText;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleHeros(int indexToEnable)
    {
        for (int i = 0; i < Heros.Length; i++)
        {
            Heros[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleHeroSidebar(int indexToEnable)
    {
        for (int i = 0; i < HerosSidebar.Length; i++)
        {
            HerosSidebar[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleStorgeSidebar(int indexToEnable)
    {
        for (int i = 0; i < StorgeSidebar.Length; i++)
        {
            StorgeSidebar[i].SetActive(indexToEnable == i);
        }
    }

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ResearchPartsTexts();
    }

    public void ResearchPartsTexts()
    {
        Text[0].text = " " + IM.MediumBullets + " / " + IM.MaxMediumBullets + " ";
        Text[1].text = " " + IM.LightBullets + " / " + IM.MaxLightBullets + " ";
        Text[2].text = " " + IM.Shells + " / " + IM.MaxShells + " ";
        Text[3].text = " " + IM.HeavyBullets + " / " + IM.MaxHeavyBullets + " ";
        Text[4].text = " " + IM.Rockets + " / " + IM.MaxRockets + " ";
        Text[5].text = " " + IM.wood + " / " + IM.MaxWood + " ";
        Text[6].text = " " + IM.scrap + " / " + IM.MaxScrap + " ";
        Text[7].text = " " + IM.goldBar + " ";
        Text[8].text = " " + IM.gunXp + " ";
        Text[9].text = " " + IM.heroXp + " ";

        CraftAmmoText[0].text = " Scrap: " + IM.scrap + " / " + " 1 " + " ";
        CraftAmmoText[1].text = " Scrap: " + IM.scrap + " / " + " 1 " + " ";
        CraftAmmoText[2].text = " Scrap: " + IM.scrap + " / " + " 1 " + " ";
        CraftAmmoText[3].text = " Scrap: " + IM.scrap + " / " + " 1 " + " ";
        CraftAmmoText[4].text = " Scrap: " + IM.scrap + " / " + " 5 " + " ";
    }
}
