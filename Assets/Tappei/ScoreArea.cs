using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �X�R�A���l���ł���G���A
/// </summary>
public class ScoreArea : MonoBehaviour
{
    /// <summary>�l���ł���X�R�A</summary>
    [Header("�l���ł���X�R�A"), SerializeField] int _score;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /// <summary>�Q�[���}�l�[�W���[�X�R�A�����Z</summary>
    public void AddScore()
    {
        GameManager._gm.AddScore(_score);
    }
}
