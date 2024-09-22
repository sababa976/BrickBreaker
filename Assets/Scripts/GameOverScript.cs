using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void RestartGame()
    {
        if (GameManage.Instance != null)
        {
            GameManage.Instance.NewGame();
        }
        else
        {
            SceneManager.LoadScene("Global");
        }
    }   
}
