using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private PlayerController _playerController;
    private GameManager _gameManger;

    [SerializeField]
    private Text _lives;
    [SerializeField]
    private Text _coins;

    void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        if(_playerController == null)
        {
            Debug.Log("ERROR UIManager.cs -> PlayerController GetComponent");
        }

        _gameManger = GameObject.Find("Game_Manager").GetComponent<GameManager>();
        if(_gameManger == null)
        {
            Debug.Log("ERROR UIManager.cs -> GameManager GetComponent");
        }
    }

    private void Update()
    {
        _lives.text = "Lives: " + _playerController.Lives.ToString();   
        _coins.text = "Coins: " + _gameManger.Coins.ToString();
    }


}
