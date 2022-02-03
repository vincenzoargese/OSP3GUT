using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // TODO: Singleton

    [SerializeField]
    private int _lives = 3;
    public float Lives => _lives;

    [SerializeField]
    private Transform _playerStartPosition;

    /* Character Controller
    **************************/
    private CharacterController _characterController;
    [SerializeField]
    private float _gravity = -1.0f;
    [SerializeField]
    private float _speed = 5.0f;
    [SerializeField]
    private float _jumpHeigth = 10.0f;
    private bool _doubleJump = false;
    private Vector3 _move, _velocity;
    [SerializeField]
    private float _yVelocity; // Need to store velocity

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        if(_characterController == null)
        {
            Debug.Log("ERROR PlayerController.cs -> _characterController is Null");
        }
    }

    void Update()
    {
        calcolateMuvement();
    }

    private void calcolateMuvement()
    {
        if(_characterController.enabled)
        {
            // Read Input
            _move = new Vector3(Input.GetAxis("Horizontal"),0,0);
            _velocity = _move * _speed;

            // Jump
            if(_characterController.isGrounded)
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    _yVelocity = _jumpHeigth * -2.0f * _gravity;
                    _doubleJump = true;
                }
            }
            else
            {
                if(Input.GetKeyDown(KeyCode.Space) && _doubleJump)
                {
                    _yVelocity = _jumpHeigth * -2.0f * _gravity;
                    _doubleJump = false;
                } 
                _yVelocity += _gravity;
            }

            _velocity.y = _yVelocity;
            _characterController.Move(_velocity * Time.deltaTime);
        }
    }

        /* Damage and GameOver
    ************************/
    public delegate void PlayerDeath();
    public event PlayerDeath gameOver;

    public void Death()
    {
        if(_lives > 1)
        {
            _lives--;
            StartCoroutine(RespawnPlayerStartPosition());
        }
        else
        {
            if(gameOver != null)
            {
                // Debug.Log("Game Over");
                gameOver();
            }
        }
    }

    IEnumerator RespawnPlayerStartPosition()
    {
        _characterController.enabled = false;
        yield return new WaitForSeconds(0.1f);
        transform.position = _playerStartPosition.position;
        _characterController.enabled = true;
    }


}
