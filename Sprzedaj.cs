using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprzedaj : MonoBehaviour
{

    public GameObject Panel;
    public GameObject StatusTekst;
    public static string tekst = "Sprzedałeś cały kamień!";
    public void klikniecie()
    {
        
        if (Kamien.Liczbakamien == 0)
        {
           tekst = "Sprzedałeś cały kamień!";
            StatusTekst.GetComponent<Text>().text = tekst;
            StatusTekst.GetComponent<Animation>().Play("StatusTekst");

        }
        else
        {
            Zloto.liczbazloto += Kamien.Liczbakamien;
            Kamien.Liczbakamien -= Kamien.Liczbakamien;
            
        }
    }
    public void sprzedajzelazo()
    {
        if (Kamien.Liczbazelazo == 0)
        {
            tekst = "Sprzedałeś całe zelazo!";
            StatusTekst.GetComponent<Text>().text = tekst;
            StatusTekst.GetComponent<Animation>().Play("StatusTekst");

        }
        else
        {
            Zloto.liczbazloto += (Kamien.Liczbazelazo*10);
            Kamien.Liczbazelazo -= Kamien.Liczbazelazo;

        }
    }
}

