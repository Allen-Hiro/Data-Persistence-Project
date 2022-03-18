using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public GameObject StartCanvas;
    public void StartNew()
    {
        SceneManager.LoadScene(1);
        StartCanvas.SetActive(false);
    }
}
