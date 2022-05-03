using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    private Rigidbody2D _rb2D;
    private readonly float _jumpVelocity = 6.5f;
    private readonly float _fallMultiplyer = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        _rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            _rb2D.velocity = _jumpVelocity * Vector2.up;
        }

        if (_rb2D.velocity.y < 0)
        {
            _rb2D.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplyer - 1) * Time.deltaTime;
        }
    }
}
