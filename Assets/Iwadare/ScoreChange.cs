using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour
{
    //�_���̕ۑ��ۑ���
    public static string _scoreString = "999999";
    //�X�R�A�̃e�L�X�g
    [SerializeField] Text _scoreText;

    /// <summary> �X�R�A�e�L�X�g��ݒ肷�� </summary>
    /// <param name="input">  </param>
    public void SetName(InputField input)
    {
        input.text = GameManager._gm.TotalScore.ToString();
        _scoreString = input.text;
    }

    void Set_Score()
    {
        _scoreString= GameManager._gm.TotalScore.ToString();
    }

    void Start()
    {
        Set_Score();
        _scoreText.text = _scoreString;
        Debug.Log(_scoreText.text);
    }

    void Update()
    {
        
    }
}
