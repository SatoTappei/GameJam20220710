using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour
{
    //点数の保存保存先
    public static string _scoreString = "999999";
    //スコアのテキスト
    [SerializeField] Text _scoreText;

    /// <summary> スコアテキストを設定する </summary>
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
