using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleFromInstructions : MonoBehaviour
{
    public Canvas titleCanvas, instructionsCanvas;

    //on-click function for return button of instructions screen - goes to title screen
    public void goToTitle()
    {
        instructionsCanvas.enabled = false;
        titleCanvas.enabled = true;
    }
}
