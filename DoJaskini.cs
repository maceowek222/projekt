using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoJaskini : MonoBehaviour
{
    public void LoadScene(string Powrot)
    {
        SceneManager.LoadScene(Powrot);
    }
}
