using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    [SerializeField] string _gameZone_TagName;

    [SerializeField] Color[] _colors;

    void Start()
    {
        //ƒ‰ƒ“ƒ_ƒ€‚È•ûŒü‚É”­ŽË
        Vector2 direction;
        float directionX;
        float directionY;
        while (true)
        {
            directionX = UnityEngine.Random.Range(-1f, 1f);
            directionY = UnityEngine.Random.Range(-1f, 1f);
            if (!Mathf.Approximately(directionX, 0)) break;
            if (!Mathf.Approximately(directionY, 0)) break;
        }
        direction = new Vector2(directionX, UnityEngine.Random.Range(-1f, 1f)).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * _moveSpeed;

        GetComponent<SpriteRenderer>().color = _colors[UnityEngine.Random.Range(0, _colors.Length)];
    }

    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _gameZone_TagName)
        {
            Destroy(this.gameObject);
        }
    }
}
