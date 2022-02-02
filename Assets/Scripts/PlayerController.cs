using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Singleton

    // Character Controller
    private CharacterController _characterController;

    [SerializeField]
    private float gravity = -1.0f, 
    _speed = 15.0f;

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
