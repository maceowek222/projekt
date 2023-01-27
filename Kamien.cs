using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kamien : MonoBehaviour
{
    public static int Liczbakamien;
    public static int Liczbakrysztaly;
    public static int Liczbazelazo;
    public GameObject WyswietlaczKamien;
    public GameObject WyswietlaczZelazo;
    public GameObject Wyswietlaczkrysztaly;
    public int kamien;
    public int zelazo;
    public int krysztaly;


    void Update()
    {
        kamien = Liczbakamien;
        WyswietlaczKamien.GetComponent<Text>().text= "Kamień: "+kamien;

        zelazo = Liczbazelazo;
        WyswietlaczZelazo.GetComponent<Text>().text = "Żelazo: " + zelazo;
        krysztaly = Liczbakrysztaly;
        Wyswietlaczkrysztaly.GetComponent<Text>().text = "Kryształy: " + krysztaly;
    }
}
