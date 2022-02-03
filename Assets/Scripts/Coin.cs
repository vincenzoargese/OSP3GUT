using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("Game_Manager").GetComponent<GameManager>();
        if(_gameManager == null)
        {
            Debug.Log("ERROR coins.cs -> Doesen't grab Game_Manager script class");
        }    
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            _gameManager.AddCoin();
            gameObject.SetActive(false);
        }
    }
}
