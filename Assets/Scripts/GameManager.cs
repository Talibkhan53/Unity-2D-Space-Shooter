using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverScreen;
   
    void Start()
    {
        //gameOverScreen.SetActive(false);
    }
    public void TriggerGameOver() {
        Debug.Log("Function Called");
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    public void RestartGame() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
