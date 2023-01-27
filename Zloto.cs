using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zloto : MonoBehaviour
{
    public static int liczbazloto;
    public GameObject WyswietlaczHajs;
    public int zloto;

    void Update()
    {
        zloto = liczbazloto;
        WyswietlaczHajs.GetComponent<Text>().text = zloto+"$";
    }
}

