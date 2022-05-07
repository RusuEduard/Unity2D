using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    private readonly float _speed = 5f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * _speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -138f)
        {
            Destroy(gameObject);
        }
    }
}
