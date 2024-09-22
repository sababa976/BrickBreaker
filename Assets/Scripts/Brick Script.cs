using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Ball")
        {
            this.gameObject.SetActive(false);
            FindObjectOfType<GameManage>().AddScore();
        }
    }
}
