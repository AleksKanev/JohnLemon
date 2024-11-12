using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour
{
    public Item item;
    public GameObject Icon;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PickUp();
        }
    }

    void PickUp() {
        Debug.Log("Picking up" + item.name); 
        gameObject.SetActive(false);
        Icon.SetActive(true);
    }

}
