using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameChanged : MonoBehaviour
{
    string playerName;
    public InputField nameBox;
    public void EditName()
    {
        StartGame.nameEntered = true;
        playerName = nameBox.text;
        PlayerPrefs.SetString("name", playerName);
    }
}
