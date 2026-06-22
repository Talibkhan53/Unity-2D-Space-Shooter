using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    public float score = 0f;
    public void AddScore() {
        Debug.Log(score);
        score++;
        scoreText.text = "Score: " + score; 
    }
}
