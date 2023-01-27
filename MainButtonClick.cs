using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainButtonClick : MonoBehaviour
{

   
    public GameObject StatusTekst;
    public GameObject panel;
    string tekst = "Musisz kupić kilof do kryształów";
    public void klikniecie()
    {

        Kamien.Liczbakamien += 1;


        int rnd = Random.Range(1, 100);
        if (rnd < 30)
        {
            Kamien.Liczbazelazo += 1;

        }

    }

    public void krysztal()
    {
        if (Zmiennakilof.kilof_krysztal == 1)
        {

            Kamien.Liczbakrysztaly += 1;
        }
        else
        {

            StatusTekst.GetComponent<Text>().text = tekst;
            StatusTekst.GetComponent<Animation>().Play("StatusTekst");

        }
    }





}


        

    

