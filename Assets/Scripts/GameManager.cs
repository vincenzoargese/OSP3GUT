using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // TODO: Singleton
    private PlayerController _PlayerController;

    private void Start() {

        if(SceneManager.GetActiveScene().name == "GameScene"){
            _PlayerController = GameObject.Find("Player").GetComponent<PlayerController>();
            if(_PlayerController != null)
            {
                _PlayerController.gameOver += gameOver;
            }        
        }
    }
    
    private void OnDestroy() {
        if(_PlayerController != null)
        {
            _PlayerController.gameOver -= gameOver;
        }
    }

    private void gameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadLoadScene()
    {
        SceneManager.LoadScene("LoadScene");
    }

}
