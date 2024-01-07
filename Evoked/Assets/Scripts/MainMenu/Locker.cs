using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    public GameObject[] Pages;
    public GameObject[] Sidebar;
    public GameObject[] Heros;

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

    public void ToggleSidebar(int indexToEnable)
    {
        for (int i = 0; i < Sidebar.Length; i++)
        {
            Sidebar[i].SetActive(indexToEnable == i);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
