using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutroManager : MonoBehaviour
{    
    public void clickRestart()
    {
        SceneManager.LoadScene(1);
    }

    public void clickReturn()
    {
        SceneManager.LoadScene(0);
    }
    
    public void clickExit()
    {
        Application.Quit();
    }
}
