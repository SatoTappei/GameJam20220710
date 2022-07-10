using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �{�҂̃}�l�[�W���[
/// </summary>
public class PlaySceneManager : MonoBehaviour
{
    [SerializeField] JudgScore _judgScore;
    /// <summary>���̃V�[���ւ̃{�^��</summary>
    [SerializeField] GameObject _nextButton;

    void Start()
    {
        _judgScore._activeNextButton = ActiveNextButton;
    }

    void Update()
    {
        
    }

    public void ActiveNextButton() => _nextButton.SetActive(true);

    /// <summary>���̃V�[���ֈڍs</summary>
    public void MoveNextScene()
    {
        string name = GameManager._gm.RoundScores.Count == 3 ? "Result" : "Play";
        SceneManager.LoadScene(name);
    }
}
