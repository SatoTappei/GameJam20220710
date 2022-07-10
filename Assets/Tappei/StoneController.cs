using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーが投げるストーンのスクリプト
/// </summary>
public class StoneController : MonoBehaviour
{
    /// <summary>ストーンが停止する速度</summary>
    [Header("ストーンが停止する速度"), Range(0.001f, 0.1f), SerializeField] float _stopSpeed;
    /// <summary>ストーンを飛ばす力にかける倍率</summary>
    [Header("ストーンを飛ばす力にかける倍率"),SerializeField] int _forceMag;
    /// <summary>マウスのボタンを押した時のストーンの位置</summary>
    Vector3 _stonePos;
    /// <summary>マウスのボタンを離した時のマウスの位置</summary>
    Vector3 _mousePos;
    /// <summary>力を加えるかどうか</summary>
    bool _isAddForce;
    /// <summary>発射済みかどうか</summary>
    bool _isShoted;

    Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void Update()
    {
        if (_isShoted) return;

        if (Input.GetMouseButtonDown(0))
        {
            _stonePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _isAddForce = true;
            _isShoted = true;
        }
    }

    void FixedUpdate()
    {
        if (_isAddForce)
        {
            // マウスの座標とストーンの座標からストーンを飛ばす力を計算
            Vector3 force = -1 * (_mousePos - _stonePos);

            _rb.AddForce(force * _forceMag, ForceMode2D.Impulse);
            _isAddForce = false;
        }
        else if (!_isAddForce && _rb.velocity != Vector2.zero)
        {
            _rb.velocity *= 0.99f;
        }
        
        if(_rb.velocity.magnitude < _stopSpeed)
        {
            //Debug.Log("止まった");
            _rb.velocity = Vector2.zero;
        }
    }
}
