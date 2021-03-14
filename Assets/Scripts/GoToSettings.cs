using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToSettings : MonoBehaviour
{
    public Canvas titleCanvas, settingsCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        settingsCanvas.enabled = false;
    }

    // on-click function for settings button of title screen - goes to settings screen
    public void clickSettings()
    {
        titleCanvas.enabled = false;
        settingsCanvas.enabled = true;
    }
}
