using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int score;
    public Text scoreText;


    private void Start()
    {
        Time.timeScale = 1;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(0);
    }
}
