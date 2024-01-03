using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armory : MonoBehaviour
{
    public GameObject[] Pages;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
