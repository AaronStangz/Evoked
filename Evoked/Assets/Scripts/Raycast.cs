using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask Interactable;
    [SerializeField] private LayerMask Collectable;


    void Update()
    {
        if (Camera.main == null) return;

        RaycastHit hit;

        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 1000);
        if (Physics.SphereCast(ray, 0.5f, out hit, 10, Interactable + Collectable))
        {
            if (Interactable.value == (1 << hit.collider.gameObject.layer))
            {
                Receriver receriver = hit.collider.GetComponent<Receriver>();
                if (receriver != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (Vector3.Distance(transform.position, receriver.transform.position) < receriver.OpenRange)
                        {
                            Debug.Log("Opened");
                            receriver.Open();
                        }
                    }
                }
            }
        }
    }

}
