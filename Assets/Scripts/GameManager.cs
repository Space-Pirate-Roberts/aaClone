using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false, outOfTime = false;

    public Rotator rotator;
    public Spawner spawner;
    public Text livesText, timeText;
    public int lives;

    public float timeRemaining;
    
    public Animator animator;


    public void Start()
    {
        lives = PlayerPrefs.GetInt("lives");
        livesText.text = lives.ToString() + " Remaining";
        timeRemaining = PlayerPrefs.GetInt("time", 15);
    }
    public void EndGame()
    {
        if (gameHasEnded)
            return;
        if (lives!=1 && !outOfTime)
        {
            lives--;
            livesText.text = lives.ToString() + " Remaining";
            return;
        }
        rotator.enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("EndGame");
        gameHasEnded = true;
        //Debug.Log("END GAME");
    }

    private void Update()
    {
        timeRemaining -= (1 * Time.deltaTime);
        timeText.text = timeRemaining.ToString("0");
        if (timeRemaining < 0)
        {
            outOfTime = true;
            EndGame();
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(2);
    }
}
