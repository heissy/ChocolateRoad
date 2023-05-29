using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collectable : MonoBehaviour
{
    public int value;
    public TextMeshProUGUI scoreText;

    int score = 10;

    private ScoreManager scoreManager;

    // Update is called once per frame
    void Update()
    {
        
    }
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        GameManager.instance.Collect(value, gameObject);

        AudioSource source = GetComponent<AudioSource>();
        source.Play();

        if (other.CompareTag("Player"))
        {
            scoreManager.IncreaseScore(score);
        }

    }

    void OnPlayerEnter (PlayerController player)
    {
        
      
    }
}
