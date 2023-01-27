using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zmiennakilof : MonoBehaviour
{
    public GameObject StatusTekst2;
    public GameObject panel;
    public static int klik;
    public static int kilof_krysztal;
    string tekst = "Masz za mało złota";
    string tekst3 = "Kupiłeś kilof do kryształów";
    string tekst4 = "Już kupiłeś kilof do kryształów";
    string tekst2 = "Kupiłeś już wszystkie kilofy";
    public void cus()
    {

        if (Zloto.liczbazloto <= 100)
        {

            StatusTekst2.GetComponent<Text>().text = tekst;
            StatusTekst2.GetComponent<Animation>().Play("StatusTekst");

        }
        else
        {
            if (klik < 4)
            {
                Zloto.liczbazloto -= 100;

                klik += 1;
            }

            else
            {
                StatusTekst2.GetComponent<Text>().text = tekst2;
                StatusTekst2.GetComponent<Animation>().Play("StatusTekst");
            }
        }
    }
    public void krysztal()
    {
        if (Zloto.liczbazloto <= 90000000)
        {

            StatusTekst2.GetComponent<Text>().text = tekst;
            StatusTekst2.GetComponent<Animation>().Play("StatusTekst");

        }
        else
        {
            if (kilof_krysztal == 0)
            {
                kilof_krysztal += 1;
                StatusTekst2.GetComponent<Text>().text = tekst3;
                StatusTekst2.GetComponent<Animation>().Play("StatusTekst");
            }
            else
            {
                StatusTekst2.GetComponent<Text>().text = tekst4;
                StatusTekst2.GetComponent<Animation>().Play("StatusTekst");
            }

        }


    }
}
