using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameWonScreen;
    public GameObject gamePausedScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // If the player presses Escape, pause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }

        // If reached the score limit, win the game
        if (playerScore >= 99)
        {
            GameWon();
        }
    }
    
    [ContextMenu("Increase Score")]
    public void IncreaseScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        gamePausedScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        gamePausedScreen.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void GameWon()
    {
        Time.timeScale = 0;
        gameWonScreen.SetActive(true);
    }
}
