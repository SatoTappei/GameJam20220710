using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��Q���̃W�F�l���[�^
/// </summary>
public class ObstacleGenerator : MonoBehaviour
{
    /// <summary>���������Q���̐�</summary>
    [Header("���������Q���̐�"), SerializeField] int _obstMax;
    /// <summary>��Q���̃v���n�u</summary>
    [Header("��Q��"), SerializeField] GameObject _obstacle;
    /// <summary>��Q���𐶐�����͈͂̍���</summary>
    [Header("��Q���𐶐�����͈͂̍���"), SerializeField] Transform _leftUpPoint;
    /// <summary>��Q���𐶐�����͈͂̉E��</summary>
    [Header("��Q���𐶐�����͈͂̉E��"), SerializeField] Transform _rightBottomPoint;
    /// <summary>�X�R�A���l���ł���G���A</summary>
    [Header("�X�R�A���l���ł���G���A"), SerializeField] LayerMask _mask;


    void Start()
    {
        int num = 0;
        while (num <= _obstMax)
        {
            float rx = Random.Range(_leftUpPoint.position.x, _rightBottomPoint.position.x);
            float ry = Random.Range(_leftUpPoint.position.y, _rightBottomPoint.position.y);
            Vector3 rayPos = new Vector3(rx, ry, 10);

            RaycastHit2D[] hits = Physics2D.RaycastAll(rayPos, Vector3.forward, Mathf.Infinity, _mask);
            if (hits.Length > 0 && hits[0].collider.tag != "Score_100" && hits[0].collider.tag != "Score_50")
            {
                Instantiate(_obstacle, new Vector3(rx, ry, 0), Quaternion.identity);
                num++;
            }
        }
    }

    void Update()
    {
        
    }
}
