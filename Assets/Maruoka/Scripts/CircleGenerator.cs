using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGenerator : MonoBehaviour
{
    [SerializeField] GameObject _circlePrefab;
    [SerializeField] float _interval;
    float _timer;

    void Start()
    {
        _timer = 0;
    }

    void Update()
    {
        //”­ŽË‚·‚é
        //interval‚ð‘Ò‚Â
        _timer += Time.deltaTime;
        if (_timer > _interval)
        {
            Instantiate(_circlePrefab, transform.position, Quaternion.identity);
            _timer = 0;
        }
    }
}
