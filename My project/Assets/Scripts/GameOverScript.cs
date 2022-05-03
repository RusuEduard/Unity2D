using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    [SerializeField]
    private Text pointsText;
    private float originalTimeScale = 1;
    public void Setup(int score)
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
        pointsText.text = "Score: " + score.ToString();
    }

    public void RestartButton()
    {
        Time.timeScale = originalTimeScale;
        SceneManager.LoadScene("Game");
    }
}
