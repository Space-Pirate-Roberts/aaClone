using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetName : MonoBehaviour
{
    public Text playerName;
    
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = PlayerPrefs.GetString("name");    
    }

}
