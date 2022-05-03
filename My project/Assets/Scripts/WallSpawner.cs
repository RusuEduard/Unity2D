using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField]
    private WallController wallPrefab;
    [SerializeField]
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWall", 0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnWall()
    {
        var position = new Vector3(33f, Random.Range(-2f, 1f), 0);
        var wall =  Instantiate(wallPrefab, position, transform.rotation);
        wall.Initialize(scoreManager);
    }
}
