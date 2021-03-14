using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleFromSettings : MonoBehaviour
{
    public Canvas titleCanvas, settingsCanvas;

    //on-click function for return button of settings screen - goes to title screen
    public void goToTitle()
    {
        settingsCanvas.enabled = false;
        titleCanvas.enabled = true;
    }
}
