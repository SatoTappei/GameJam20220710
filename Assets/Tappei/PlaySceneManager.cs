using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 本編のマネージャー
/// </summary>
public class PlaySceneManager : MonoBehaviour
{
    [SerializeField] JudgScore _judgScore;
    /// <summary>次のシーンへのボタン</summary>
    [SerializeField] GameObject _nextButton;

    void Start()
    {
        _judgScore._activeNextButton = ActiveNextButton;
    }

    void Update()
    {
        
    }

    public void ActiveNextButton() => _nextButton.SetActive(true);

    /// <summary>次のシーンへ移行</summary>
    public void MoveNextScene()
    {
        string name = GameManager._gm.RoundScores.Count == 3 ? "Result" : "Play";
        SceneManager.LoadScene(name);
    }
}
