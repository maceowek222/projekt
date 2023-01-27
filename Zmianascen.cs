using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Zmianascen : MonoBehaviour
{
    public void LoadScene(string DoSklep)
    {
        SceneManager.LoadScene(DoSklep);
    }
}
