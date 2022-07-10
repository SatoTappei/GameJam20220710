using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[��������X�g�[���̃X�N���v�g
/// </summary>
public class StoneController : MonoBehaviour
{
    /// <summary>�X�g�[������~���鑬�x</summary>
    [Header("�X�g�[������~���鑬�x"), Range(0.001f, 0.1f), SerializeField] float _stopSpeed;
    /// <summary>�X�g�[�����΂��͂ɂ�����{��</summary>
    [Header("�X�g�[�����΂��͂ɂ�����{��"),SerializeField] int _forceMag;
    /// <summary>�}�E�X�̃{�^�������������̃X�g�[���̈ʒu</summary>
    Vector3 _stonePos;
    /// <summary>�}�E�X�̃{�^���𗣂������̃}�E�X�̈ʒu</summary>
    Vector3 _mousePos;
    /// <summary>�͂������邩�ǂ���</summary>
    bool _isAddForce;
    /// <summary>���ˍς݂��ǂ���</summary>
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
            // �}�E�X�̍��W�ƃX�g�[���̍��W����X�g�[�����΂��͂��v�Z
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
            //Debug.Log("�~�܂���");
            _rb.velocity = Vector2.zero;
        }
    }
}
