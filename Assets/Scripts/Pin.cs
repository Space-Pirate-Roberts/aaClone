using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    float playerPinSpeed;

    private bool isPinned = false;
    private bool outOfPlay = false;

    private void Start()
    {
        playerPinSpeed = PlayerPrefs.GetFloat("pinspeed");
    }

    void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * playerPinSpeed * Time.deltaTime);    
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            if(!outOfPlay)
                Score.PinCount++;
            //col.GetComponent<Rotator>().speed += 50; //speed up rotation
            //col.GetComponent<Rotator>().speed *= -1; //reverse rotation
            isPinned = true;
            outOfPlay = true;
        } /*else if (col.tag == "Pin")
        {
            if (!outOfPlay)
            {
                outOfPlay = true;
                FindObjectOfType<GameManager>().EndGame();
            }
        }*/
    }
}
