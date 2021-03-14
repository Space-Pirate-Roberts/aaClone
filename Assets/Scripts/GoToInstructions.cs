using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToInstructions : MonoBehaviour
{
    public Canvas titleCanvas, instructionsCanvas;

    // Start is called before the first frame update
    void Start()
    {
        instructionsCanvas.enabled = false;
    }

    // on-click function for how to play button of title screen - goes to instructions screen
    public void clickHowToPlay()
    {
        titleCanvas.enabled = false;
        instructionsCanvas.enabled = true;
    }
}
