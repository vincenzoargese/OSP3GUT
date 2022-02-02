using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // TODO: Singleton

    private void Start() {

    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
