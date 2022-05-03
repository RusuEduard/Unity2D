using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    private readonly float _speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * _speed * Time.deltaTime, 0, 0);
        if (transform.position.x < -13f)
        {
            Destroy(gameObject);
        }
    }
}
