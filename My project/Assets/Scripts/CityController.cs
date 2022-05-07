using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityController : MonoBehaviour
{
    [SerializeField]
    private GameObject cityPrefab;
    private readonly float _speed = 10f;
    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawned && gameObject.transform.position.x <= -19f)
        {
            Instantiate(cityPrefab, new Vector3(300f, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
            spawned = true;
        }

        transform.Translate(-1 * _speed * Time.deltaTime, 0, 0);

        if (transform.position.x < -338f)
        {
            Destroy(gameObject);
        }
    }
}
