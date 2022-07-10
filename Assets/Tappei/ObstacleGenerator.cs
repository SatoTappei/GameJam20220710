using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 障害物のジェネレータ
/// </summary>
public class ObstacleGenerator : MonoBehaviour
{
    /// <summary>生成する障害物の数</summary>
    [Header("生成する障害物の数"), SerializeField] int _obstMax;
    /// <summary>障害物のプレハブ</summary>
    [Header("障害物"), SerializeField] GameObject _obstacle;
    /// <summary>障害物を生成する範囲の左上</summary>
    [Header("障害物を生成する範囲の左上"), SerializeField] Transform _leftUpPoint;
    /// <summary>障害物を生成する範囲の右下</summary>
    [Header("障害物を生成する範囲の右下"), SerializeField] Transform _rightBottomPoint;
    /// <summary>スコアを獲得できるエリア</summary>
    [Header("スコアを獲得できるエリア"), SerializeField] LayerMask _mask;


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
