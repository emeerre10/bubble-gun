using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject lifes;
    public GameObject continueButton;
    public GameObject playButton;
    public GameObject restartButton;
    public GameObject bubble;

    private GameObject bubbleCopy;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        Lifes.lifes--;
        if (Lifes.lifes > 0)
        {
            continueButton.SetActive(true);
            bubbleCopy.SetActive(false);
            Destroy(bubbleCopy, 0.1f);
            Time.timeScale = 0;

        } else
        {
            restartButton.SetActive(true);
            bubbleCopy.SetActive(false);
            Destroy(bubbleCopy, 0.1f);
            Time.timeScale = 0;
        }
    }

    public void Continue()
    {
        continueButton.SetActive(false);
        bubbleCopy = Instantiate(bubble);
        bubbleCopy.SetActive(true);
        Time.timeScale = 1;
    }

    public void Play()
    {
        bubbleCopy = Instantiate(bubble);
        bubbleCopy.SetActive(true);
        playButton.SetActive(false);
        lifes.SetActive(true);
        Time.timeScale = 1;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
