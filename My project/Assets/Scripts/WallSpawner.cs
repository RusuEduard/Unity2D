using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject Wall;

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
        var position = new Vector3(14f, Random.Range(-2f, 1f), 0);
        Instantiate(Wall, position, transform.rotation);
    }
}
