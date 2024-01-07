using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSlot : MonoBehaviour
{
    ItemManager IM;
    public GameObject mainManger;

    public GameObject[] Slot1;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
        ReSlot();
    }

    void Update()
    {
        
    }

    public void ReSlot()
    {
        int randomIndex = Random.Range(0, Slot1.Length);
        for (int i = 0; i < Slot1.Length; i++)
        {
            //Slot1[randomIndex].SetActive(true);
            if (i == randomIndex)
            {
                Slot1[i].SetActive(true);
            }
            else
            {
                Slot1[i].SetActive(false);
            }
        }
    }

    public void GoldForEclipseEnforcerParts()
    {
        if (IM.goldBar >= 200)
        {
            Debug.Log("Buy");
            IM.goldBar -= 200;
            IM.eclipseEnforcerParts += 10;
            ReSlot();
        }
    }

    public void GoldForPhantomWhisperParts()
    {
        if (IM.goldBar >= 200)
        {
            Debug.Log("Buy");
            IM.goldBar -= 200;
            IM.phantomWhisperParts += 10;
            ReSlot();
        }
    }

    public void GoldForCobaltSentinelParts()
    {
        if (IM.goldBar >= 200)
        {
            Debug.Log("Buy");
            IM.goldBar -= 200;
            IM.cobaltSentinelParts += 10;
            ReSlot();
        }
    }

    public void GoldForZenithDefenderParts()
    {
        if (IM.goldBar >= 200)
        {
            Debug.Log("Buy");
            IM.goldBar -= 200;
            IM.zenithDefenderParts += 10;
            ReSlot();
        }
    }

    public void GoldForEmberGuardianParts()
    {
        if (IM.goldBar >= 200)
        {
            Debug.Log("Buy");
            IM.goldBar -= 200;
            IM.emberGuardianParts += 10;
            ReSlot();
        }
    }

    public void GoldForNebulaHavocParts()
    {
        if (IM.goldBar >= 200)
        {
            Debug.Log("Buy");
            IM.goldBar -= 200;
            IM.nebulaHavocParts += 10;
            ReSlot();
        }
    }
}
