using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    string _enemyTag = "Enemy";

    int _gameover = 0;
    

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _enemyTag)
        {

            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GameOver");

    }
}
