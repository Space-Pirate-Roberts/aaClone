using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    public Slider rotation, pinSpeed;
    public Dropdown lives, timer;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("rotation", 1f);
        PlayerPrefs.SetFloat("pinspeed", 1f);
        PlayerPrefs.SetInt("lives", 1);
        PlayerPrefs.SetInt("time", 30);
    }

    public void adjustRotationSpeed()
    {
        PlayerPrefs.SetFloat("rotation", rotation.value);
    }

    public void adjustPinSpeed()
    {
        PlayerPrefs.SetFloat("pinspeed", pinSpeed.value);
    }

    public void adjustLives()
    {
        PlayerPrefs.SetInt("lives", lives.value + 1);
    }

    public void adjustTime()
    {
        PlayerPrefs.SetInt("time", 15 + (timer.value * 15));
    }

}
