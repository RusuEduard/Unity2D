using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ScoreManager")]
public class ScoreManager : ScriptableObject
{
    public int Score { get; set; }
    // Start is called before the first frame update
    private void OnEnable()
    {
        this.Score = 0;
    }
}
