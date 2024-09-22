using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  
public class ScoreUI : MonoBehaviour
{
     public TextMeshProUGUI scoreText;  // For regular UI Text
    // public TextMeshProUGUI scoreText;  // Use this line if you're using TextMeshPro

    private void Update()
    {
        if (GameManage.Instance != null)
        {
            scoreText.text = "Score: " + GameManage.Instance.score.ToString() + "   Lives: "+ GameManage.Instance.lives.ToString();
        }
    }
}
