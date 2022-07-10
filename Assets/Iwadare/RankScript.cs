using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankScript : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    [SerializeField] GameObject _kin;
    [SerializeField] GameObject _gin;
    [SerializeField] GameObject _dou;
    int _score;
    // Start is called before the first frame update
    void Start()
    {
        _score = int.Parse(_scoreText.text);
        if(_score < 100)
        {
            Debug.Log("ƒƒ_ƒ‹‚È‚µ");
        }
        else if(_score < 200)
        {
            _dou.gameObject.SetActive(true);
        }
        else if(_score < 250)
        {
            _gin.gameObject.SetActive(true);
        }
        else
        {
            _kin.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
