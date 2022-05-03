using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    private Text _text;
    [SerializeField]
    private ScoreManager _scoreManager;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = _scoreManager.Score.ToString();
    }
}
