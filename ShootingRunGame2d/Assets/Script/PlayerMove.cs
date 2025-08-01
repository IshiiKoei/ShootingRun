using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 5.0f;
    [SerializeField] float _JumpForce = 4.0f;
    private Rigidbody2D _rd;
    int _JumpCount;
    public int _MaxJumpCount;
    private bool _IsTouch;

    // Start is called before the first frame update
    void Start()
    {
        _rd = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        _rd.velocity = new Vector2(_moveSpeed, _rd.velocity.y);
    }
    private void Jump()
    //ジャンプ関係 (ジャンプ方法、ジャンプ制限)
    {
        if (Input.GetKeyDown(KeyCode.Space) && _JumpCount < _MaxJumpCount)
        {
            
            _rd.AddForce(new Vector2(0f, _JumpForce),ForceMode2D.Impulse);
            _JumpCount++;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grounded"))
        {
           _JumpCount = 0; 
        }
    }
}
