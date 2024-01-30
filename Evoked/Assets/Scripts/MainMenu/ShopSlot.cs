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
            IM.xp += 50;
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
            IM.xp += 50;
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
            IM.xp += 50;
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
            IM.xp += 50;
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
            IM.xp += 50;
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
            IM.xp += 50;
            ReSlot();
        }
    }

    public void BluePrintPhantomWhisperParts()
    {
        if (IM.goldBar >= 500)
        {
            Debug.Log("Buy");
            IM.goldBar -= 500;
            IM.phantomWhisperBluePrints += 1;
            IM.xp += 50;
            ReSlot();
        }
    }

    public void BluePrintCobaltSentinelParts()
    {
        if (IM.goldBar >= 500)
        {
            Debug.Log("Buy");
            IM.goldBar -= 500;
            IM.cobaltSentinelBluePrints += 1;
            IM.xp += 50;
            ReSlot();
        }
    }

    public void BluePrintZenithDefenderParts()
    {
        if (IM.goldBar >= 500)
        {
            Debug.Log("Buy");
            IM.goldBar -= 500;
            IM.zenithDefenderBluePrints += 1;
            IM.xp += 50;
            ReSlot();
        }
    }

    public void BluePrintEmberGuardianParts()
    {
        if (IM.goldBar >= 500)
        {
            Debug.Log("Buy");
            IM.goldBar -= 500;
            IM.emberGuardianBluePrints += 1;
            IM.xp += 50;
            ReSlot();
        }
    }

    public void BluePrintNebulaHavocParts()
    {
        if (IM.goldBar >= 500)
        {
            Debug.Log("Buy");
            IM.goldBar -= 500;
            IM.nebulaHavocBluePrints += 1;
            IM.xp += 50;
            ReSlot();
        }
    }
}
