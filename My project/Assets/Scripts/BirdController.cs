using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    private Rigidbody2D _rb2D;
    private float _jumpVelocity = 20f;
    private readonly float _fallMultiplyer = 2f;
    [SerializeField]
    GameController gameController;
    private new SpriteRenderer renderer;
    [Header("Sprite")]
    [SerializeField]
    private Sprite upSprite;
    [SerializeField]
    private Sprite downSprite;



    // Start is called before the first frame update
    void Start()
    {
        _rb2D = gameObject.GetComponent<Rigidbody2D>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            renderer.sprite = upSprite;

            _rb2D.velocity = Vector2.up * _jumpVelocity;
        }

        if (_rb2D.velocity.y < 0)
        {
            renderer.sprite = downSprite;
            _rb2D.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplyer - 1) * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameController.GameOver();
    }
}
