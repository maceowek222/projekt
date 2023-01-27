using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kilofy : MonoBehaviour
{

   public GameObject[] kilof;


    void Start()
    {
        
        kilof = GameObject.FindGameObjectsWithTag("Kilof");
        Debug.Log(kilof.Length);
        Debug.Log(Zmiennakilof.klik);
        kilof[0].SetActive(false);
        kilof[1].SetActive(false);
        kilof[2].SetActive(false);
        if (Zmiennakilof.klik >= 1)
        {
            kilof[0].SetActive(true);
        }
        if (Zmiennakilof.klik >= 2)
        {
            kilof[1].SetActive(true);
        }
        if (Zmiennakilof.klik >= 3)
        {
            kilof[2].SetActive(true);
        }
    }

  
}
