using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;

    
    public GameObject Item;
    // Start is called before the first frame update


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!Item.active)
            {
                one.SetActive(false);
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
            }
        }
    }
}

