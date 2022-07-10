using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームマネージャー
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager _gm;

    /// <summary>1ラウンドのスコア</summary>
    List<int> _roundScores = new List<int>();
    /// <summary>トータルのスコア</summary>
    int _totalScore;

    public List<int> RoundScores { get => _roundScores; private set => _roundScores = value; }
    public int TotalScore { get => _totalScore; private set => _totalScore = value; }

    void Awake()
    {
        if(_gm == null)
        {
            _gm = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(TotalScore);
    }

    /// <summary>獲得したスコアを加算</summary>
    public void AddScore(int score)
    {
        RoundScores.Add(score);
        TotalScore += score;
    }
}
