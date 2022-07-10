using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChange : MonoBehaviour
{
    public static string _scoreString = "999999";
    [SerializeField] Text _scoreText;
    public void SetName(InputField input)
    {
        _scoreString = input.text;
    }
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = _scoreString;
        Debug.Log(_scoreText.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
