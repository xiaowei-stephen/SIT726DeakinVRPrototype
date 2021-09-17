using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Confirm()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
