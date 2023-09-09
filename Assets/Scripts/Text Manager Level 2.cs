using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManagerLevel2 : MonoBehaviour
{
    public int score;
    public int lives;
    public Text scoreText;
    public Text livesText;
    public bool gameOver;
    public GameObject gameOverScreen;
    public bool win;
    public GameObject winScreen;
    public int bricksTotal;
    public GameObject ball;  
    public Rigidbody2D ballRigidbody;  

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
        bricksTotal = GameObject.FindGameObjectsWithTag("Brick").Length;

        
        ballRigidbody = ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (bricksTotal <= 1)
        {
            
            ballRigidbody.velocity = Vector2.zero;
        }
    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        if (lives <= 0)
        {
            lives = 0;
            GameOver();
        }

        livesText.text = "Lives: " + lives;
    }

    public void UpdateScore(int changeInScore)
    {
        score += changeInScore;
        scoreText.text = "Score: " + score;
    }

    public void UpdateBricksTotal()
    {
        bricksTotal--;
        if (bricksTotal <= 1)
        {
            Win();
        }
    }

    void GameOver()
    {
        gameOver = true;
        gameOverScreen.SetActive(true);
    }

    void Win()
    {
        win = true;
        winScreen.SetActive(true);
    }

    public void PlayOnceMore()
    {
        SceneManager.LoadScene("Level 2 RBK");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu RBK");
    }
}
