using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    ItemManager IM;
    public GameObject mainManger;
    [Space]
    public TMP_Text Xp;
    [Space]
    public int level_0;
    public int level_1;
    public int level_2;
    public int level_3;
    public int level_4;
    public int level_5;
    public int level_6;
    public int level_7;

    void Start()
    {
        IM = mainManger.GetComponent<ItemManager>();
    }

   
    void Update()
    {
        if (IM.xp >= level_0)
        {
            Xp.text = "Player Level: " + "0" + " ";
        }
        if (IM.xp >= level_1)
        {
            Xp.text = "Player Level: " + "1" + " ";
        }
        if (IM.xp >= level_2)
        {
            Xp.text = "Player Level: " + "2" + " ";
        }
        if (IM.xp >= level_3)
        {
            Xp.text = "Player Level: " + "3" + " ";
        }
        if (IM.xp >= level_4)
        {
            Xp.text = "Player Level: " + "4" + " ";
        }
        if (IM.xp >= level_5)
        {
            Xp.text = "Player Level: " + "5" + " ";
        }
        if (IM.xp >= level_6)
        {
            Xp.text = "Player Level: " + "6" + " ";
        }
        if (IM.xp >= level_7)
        {
            Xp.text = "Player Level: " + "7" + " ";
        }
    }
}
