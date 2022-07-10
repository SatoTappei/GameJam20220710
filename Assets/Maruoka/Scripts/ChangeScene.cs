using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    float _timer;
    [SerializeField] float _fadeTime;
    [SerializeField] Image _fadeSprite;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnClick_SceneChange(string sceneName)
    {
        GetComponent<AudioSource>().Play();
        StartCoroutine(FadeIn(sceneName));
    }

    IEnumerator FadeIn(string sceneName)
    {
        if (GameManager._gm != null)
        {
            if (GameManager._gm.RoundScores.Count != 0)
            {
                GameManager._gm.ClearScore();
            }
        }

        while (_timer < _fadeTime)
        {
            //�^�C�}�[�����Z
            _timer += Time.deltaTime;
            //�J���[���擾
            Color c = _fadeSprite.color;
            //�A���t�@�l��ύX
            c.a = _timer / _fadeTime;
            _fadeSprite.color = c;

            yield return new WaitForEndOfFrame();   // Update() �̏������I���܂ő҂�
        }
        // �t�F�[�h����
        SceneManager.LoadScene(sceneName);
    }
}
