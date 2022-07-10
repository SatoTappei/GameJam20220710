using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// スコアを獲得できるエリア
/// </summary>
public class ScoreArea : MonoBehaviour
{
    /// <summary>獲得できるスコア</summary>
    [Header("獲得できるスコア"), SerializeField] int _score;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>ゲームマネージャースコアを加算</summary>
    public void AddScore()
    {
        GameManager._gm.AddScore(_score);
    }
}
