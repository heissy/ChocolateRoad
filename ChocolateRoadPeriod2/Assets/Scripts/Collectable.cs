using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public int value;
    public Text scoreText;

    int score = 0;

    // Update is called once per frame
    void Update()
    {
        
    }
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }

    void OnTriggerEnter(Collider other)
    {
        GameManager.instance.Collect(value, gameObject);

        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
