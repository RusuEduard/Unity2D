using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private WallController wallPrefab;
    [SerializeField]
    private GameObject cloudPrefab;
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private GameOverScript gameOverController;


    // Start is called before the first frame update
    void Start()
    {
        scoreManager.Score = 0;
        InvokeRepeating("SpawnWall", 0f, 4f);
        InvokeRepeating("SpawnClouds", 0f, 8f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnWall()
    {
        var position = new Vector3(170f, UnityEngine.Random.Range(63f, 121f), 0);
        var wall =  Instantiate(wallPrefab, position, transform.rotation);
        wall.Initialize(scoreManager);
    }

    void SpawnClouds()
    {
        var probability = Math.Round(UnityEngine.Random.Range(1f, 10f));
        if(probability < 4)
        {
            var position = new Vector3(170f, UnityEngine.Random.Range(-17f, 55f), 0);
            Instantiate(cloudPrefab, position, transform.rotation);
        }
    }

    public void GameOver()
    { 
        gameOverController.Setup(scoreManager.Score);
    }
}
