using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftAmmo : MonoBehaviour
{
    ItemManager IM;
    public GameObject mainManger;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CraftMediumBullets()
    {
        if (IM.scrap >= 1)
        {
            IM.scrap -= 1;
            IM.MediumBullets += 10;
        }
    }
    public void CraftLightBullets()
    {
        if (IM.scrap >= 1)
        {
            IM.scrap -= 1;
            IM.LightBullets += 20;
        }
    }
    public void CraftShells()
    {
        if (IM.scrap >= 1)
        {
            IM.scrap -= 1;
            IM.Shells += 10;
        }
    }
    public void CraftHeavyBullets()
    {
        if (IM.scrap >= 1)
        {
            IM.scrap -= 1;
            IM.HeavyBullets += 5;
        }
    }
    public void CraftRockets()
    {
        if (IM.scrap >= 5)
        {
            IM.scrap -= 5;
            IM.Rockets += 1;
        }
    }
}
