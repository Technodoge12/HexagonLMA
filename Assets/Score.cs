using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score;
    public float shrinkSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IncreaseScore", 3f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = score.ToString();
    }
    void IncreaseScore()
    {
        score += 1;
    }
}
