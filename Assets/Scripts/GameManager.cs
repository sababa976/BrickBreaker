using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public BallScript ball {get; private set;}
    public PaddleController paddle {get; private set;}
    public static GameManage Instance { get; private set; }
    public int score = 0;

    public int bricksLeft;
    public int lives = 3;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        NewGame();
        SceneManager.sceneLoaded +=OnLevelLoad;
    }
    private void Start()
    {        
    }
    private void OnLevelLoad(Scene scene,LoadSceneMode mode)
    {
        ball = FindObjectOfType<BallScript>();
        paddle =FindObjectOfType<PaddleController>();
    }
    public void NewGame()
    {
        score = 0;
        lives = 3;
        bricksLeft = 45;
        SceneManager.LoadScene("Level1");
    }
    public void AddScore()
    {
        score += 10;
        bricksLeft--;
        if(bricksLeft==0)
        {
            SceneManager.LoadScene("GameWon");
        }
    }
    private void ResetLevel()
    {
        ball.ResetBall();
        paddle.ResetPaddle();
    }
    private void GameLost()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void LoseLife()
    {
        lives--;
        if(lives>0)
        {
            ResetLevel();
        }
        else
        {
            GameLost();
        }
    }
}
