using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpot : MonoBehaviour
{
    public bool isCapped { get; private set; }


    private void OnTriggerEnter(Collider other)
    {
        string playerTag = "Player";
        string animalTag = "Animal";

        isCapped = other.tag == animalTag || other.tag == playerTag;
    }
    
    private void OnTriggerExit(Collider other)
    {
        string playerTag = "Player";
        string animalTag = "Animal";

        if (isCapped)
        {
            if (other.tag == animalTag || other.tag == playerTag )
            {
                isCapped = !isCapped;
            }
        }
       
       
    }
}
