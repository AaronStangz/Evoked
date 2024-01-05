using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickPlay : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainMenu;
    [Space]
    public GameObject[] Maps;

    public GameObject[] MainGuns;
    public GameObject[] SecondGuns;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayQuickPlay()
    {
        Player.SetActive(true);
        MainMenu.SetActive(false);
        int randomIndex = Random.Range(0, Maps.Length);
        for (int i = 0; i < Maps.Length; i++)
        {
            Maps[randomIndex].SetActive(true);
        }
    }

    public void MainEclipseEnforcer()
    {
        MainGuns[0].SetActive(true);
    }
    public void MainPhantomWhisper()
    {
        MainGuns[1].SetActive(true);
    }
    public void MainChcobaltSentinel()
    {
        MainGuns[2].SetActive(true);
    }
    public void MainZenithDefender()
    {
        MainGuns[3].SetActive(true);
    }
    public void MainEmberGuardian()
    {
        MainGuns[4].SetActive(true);
    }
    public void MainNebulaHavocParts()
    {
        MainGuns[5].SetActive(true);
    }
}
