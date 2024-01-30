using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMisson : MonoBehaviour
{
    public GameObject[] SideBars;
    public GameObject[] Missons;
    public GameObject[] Locks;
    public GameObject[] Buttons;
    public GameObject Player; 

    public void MissonSideBars(int indexToEnable)
    {
        for (int i = 0; i < SideBars.Length; i++)
        {
            SideBars[i].SetActive(indexToEnable == i);
        }
    }
    public void MissonsMaps(int indexToEnable)
    {
        for (int i = 0; i < Missons.Length; i++)
        {
            Missons[i].SetActive(indexToEnable == i);
        }
    }

    public void MissonsLocks(int indexToEnable)
    {
        for (int i = 0; i < Locks.Length; i++)
        {
            Locks[i].SetActive(indexToEnable == i);
        }
    }

    public void MissonsButtons(int indexToEnable)
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].SetActive(indexToEnable == i);
        }
    }

    public void Misson_1_End()
    {
        Missons[0].SetActive(false);
        Player.SetActive(false);
        Locks[1].SetActive(false);
        Buttons[0].SetActive(false);
    }

    public void Misson_2_End()
    {
        Missons[1].SetActive(false);
        Player.SetActive(false);
        Locks[2].SetActive(false);
        Buttons[1].SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
