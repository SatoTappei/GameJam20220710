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
    [SerializeField] GameObject _no;

    [SerializeField] float _waitTime;
    int _score;
    // Start is called before the first frame update
    void Start()
    {
        _score = int.Parse(_scoreText.text);
        if (_score < 100)
        {
            Debug.Log("ƒƒ_ƒ‹‚È‚µ");
            _no.gameObject.SetActive(true);
            StartCoroutine(Bgm(1));
        }
        else if (_score < 200)
        {
            _dou.gameObject.SetActive(true);
            StartCoroutine(Bgm(2));
        }
        else if (_score < 250)
        {
            _gin.gameObject.SetActive(true);
            StartCoroutine(Bgm(3));
        }
        else
        {
            _kin.gameObject.SetActive(true);
            StartCoroutine(Bgm(4));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Bgm(int rank)
    {
        Debug.Log(_waitTime);
        yield return new WaitForSeconds(_waitTime);
        switch (rank)
        {
            case 1: _no.gameObject.transform.GetChild(0).gameObject.SetActive(true); break;
            case 2: _dou.gameObject.transform.GetChild(0).gameObject.SetActive(true); break;
            case 3: _gin.gameObject.transform.GetChild(0).gameObject.SetActive(true); break;
            case 4: _kin.gameObject.transform.GetChild(0).gameObject.SetActive(true); break;
        }
        Debug.Log("aaa");
    }
}
