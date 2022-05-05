using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private WallController wallPrefab;
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private GameOverScript gameOverController;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager.Score = 0;
        InvokeRepeating("SpawnWall", 0f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnWall()
    {
        var position = new Vector3(170f, Random.Range(63f, 121f), 0);
        var wall =  Instantiate(wallPrefab, position, transform.rotation);
        wall.Initialize(scoreManager);
    }

    public void GameOver()
    { 
        gameOverController.Setup(scoreManager.Score);
    }
}
