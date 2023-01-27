using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managergry : MonoBehaviour
{
    private static Managergry instance;

    private void Awake()
    {
        if(instance !=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
