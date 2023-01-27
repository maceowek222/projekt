using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodawanie : MonoBehaviour
{


    
    public void Start()
    {
        if(Zmiennakilof.klik >=1)
        {
            InvokeRepeating("dod", 0f, 2f);
        }
        


    }

    void dod()
    {
        Kamien.Liczbakamien += Zmiennakilof.klik;
        int rnd = Random.Range(1, 100);
        if (rnd < 30)
        {
            Kamien.Liczbazelazo += 1;

        }

    }
   
}
