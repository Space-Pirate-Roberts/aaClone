using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public static bool nameEntered;
    
    // Start is called before the first frame update
    void Start()
    {
        nameEntered = false;
    }

    public void clickStart()
    {
        if (nameEntered)
        {
            SceneManager.LoadScene(1);
        }
    }
}
