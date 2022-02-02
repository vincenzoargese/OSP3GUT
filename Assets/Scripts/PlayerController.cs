using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // TODO: Singleton

    // Character Controller
    private CharacterController _characterController;

    [SerializeField]
    private float gravity = -1.0f;
    [SerializeField]
    private float _speed = 15.0f;

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
        
    }
}
