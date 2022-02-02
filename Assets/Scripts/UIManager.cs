using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private PlayerController _playerController;

    [SerializeField]
    private Text _lives;

    void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        if(_playerController == null)
        {
            Debug.Log("ERROR UIManager.cs -> PlayerController GetComponent");
        }
    }

    private void Update()
    {
        _lives.text = "Lives: " + _playerController.Lives.ToString();   
    }


}
