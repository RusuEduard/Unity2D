using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    private readonly float _speed = 2f;
    private bool _passed = false;
    private GameObject bird;
    private ScoreManager scoreManager;


    private void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird");
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * _speed * Time.deltaTime, 0, 0);

        if (!_passed && transform.position.x < bird.GetComponent<Transform>().position.x)
        {
            scoreManager.Score++;
            _passed = true;
        }

        if (transform.position.x < 0f)
        {
            Destroy(gameObject);
        }
    }

    public void Initialize(ScoreManager manager)
    {
        this.scoreManager = manager;
    }
}
