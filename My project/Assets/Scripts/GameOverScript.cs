using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private float originalTimeScale = 1;

    [SerializeField]
    private Text pointsText;
    public void Setup(int score)
    {
        originalTimeScale = Time.timeScale;
        Time.timeScale = 0;
        gameObject.SetActive(true);
        pointsText.text = "Score: " + score.ToString();
    }

    public void RestartButton()
    {
        Time.timeScale = originalTimeScale;
        SceneManager.LoadScene("Game");
    }

    public void MainMenuButton()
    {
        Time.timeScale = originalTimeScale;
        SceneManager.LoadScene("MainMenu");
    }
}
