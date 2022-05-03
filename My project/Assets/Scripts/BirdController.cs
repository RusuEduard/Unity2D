using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    private Rigidbody2D _rb2D;
    private Transform _transform;
    [Range(1, 10)]
    public float jumpVelocity;


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
            //_rb2D.AddForce(new Vector2(0f, 1f * _jumpForce), ForceMode2D.Impulse);
            //transform.Translate(new Vector2(0, 1) * _jumpForce * Time.deltaTime); 
            _rb2D.velocity = jumpVelocity * Vector2.up;
        }
    }
}
