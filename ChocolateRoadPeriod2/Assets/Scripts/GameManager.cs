using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;
    private int lives;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }

    public void StartGame(int difficulty)
    {

        score = 0;
        UpdateScore(0);
        UpdateLives(3);
        
    }

    IEnumerator SpawnTarget()
    {
        while(true)
        {
            UpdateScore(5);
        }
    }

    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
    }

    public void UpdateLives(int livesToChange)
    {
        lives += livesToChange;
        livesText.text = "Lives: " + lives;
        if (lives <= 0)
        {
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
