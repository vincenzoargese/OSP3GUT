using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private PlayerController _playerController;
    
    private void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        if(_playerController == null)
        {
            Debug.Log("ERRORE: DeathZone.cs -> Grab PlayerController");
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _playerController.Death();
        }    
    }
}
