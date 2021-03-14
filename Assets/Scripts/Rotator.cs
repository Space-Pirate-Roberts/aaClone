using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed = 100f, playerSpeed;

    private void Start()
    {
        playerSpeed = PlayerPrefs.GetFloat("rotation");
    }

    void Update()
    {
        transform.Rotate(0f, 0f, speed * playerSpeed * Time.deltaTime);    
    }

}
