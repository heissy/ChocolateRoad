using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; //reference for text component
    private int score = 0; //current score

    public void IncreaseScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
         if (scoreText != null)
         {
            scoreText.text = "Score: " + scoreText.ToString();
         }
         else
         {
            Debug.LogWarning("ScoreText component is not assigned in ScoreManager");
         }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
