using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 獲得するスコアを判定する
/// </summary>
public class JudgScore : MonoBehaviour
{
    /// <summary>Rayが衝突するレイヤー</summary>
    [Header("スコアを獲得できるエリア"), SerializeField] LayerMask _mask;
    /// <summary>前フレームの速度</summary>
    Vector3 _prevFrameVelo;

    Rigidbody2D _rb;
    public UnityAction _activeNextButton;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (_prevFrameVelo != Vector3.zero && _rb.velocity == Vector2.zero)
        {
            Debug.Log("Rayを発射");
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, Vector3.forward, Mathf.Infinity, _mask);
            if (hits.Length > 0)
            {
                //Debug.Log(hits[0].collider.name);
                hits[0].collider.GetComponent<ScoreArea>().AddScore();
            }
            else
            {
                GameManager._gm.AddScore(0);
            }
            _activeNextButton.Invoke();
        }

        _prevFrameVelo = _rb.velocity;

    }
}
