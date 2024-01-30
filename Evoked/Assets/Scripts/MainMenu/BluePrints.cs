using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BluePrints : MonoBehaviour
{
    ItemManager IM;
    public GameObject mainManger;
    [Space]
    public GameObject[] researchLocks;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
    }

    public void ResearchLocks(int indexToEnable)
    {
        for (int i = 0; i < researchLocks.Length; i++)
        {
            researchLocks[i].SetActive(indexToEnable == i);
        }
    }

    void Update()
    {
        if (IM.phantomWhisperBluePrints >= 1)
        {
            researchLocks[0].SetActive(false);
        }
        if (IM.cobaltSentinelBluePrints >= 1)
        {
            researchLocks[1].SetActive(false);
        }
        if (IM.zenithDefenderBluePrints >= 1)
        {
            researchLocks[2].SetActive(false);
        }
        if (IM.emberGuardianBluePrints >= 1)
        {
            researchLocks[3].SetActive(false);
        }
        if (IM.nebulaHavocBluePrints >= 1)
        {
            researchLocks[4].SetActive(false);
        }
    }
}
