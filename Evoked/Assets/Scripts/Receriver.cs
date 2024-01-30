using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Receriver : MonoBehaviour
{
    public GameObject receriver;
    public GameObject receriverUI;

    public GameObject[] cells;

    public int OpenRange;

    public int maxInput;

    public bool IsOpen = false;

    void Start()
    {
        
    }


    void Update()
    {
        Escape();
    }

    public void Open()
    {
        receriverUI.SetActive(true);
        IsOpen = true;
    }

    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && IsOpen == true)
        {
            ForceEscape();
        }
    }

    void ForceEscape()
    {
        IsOpen = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
