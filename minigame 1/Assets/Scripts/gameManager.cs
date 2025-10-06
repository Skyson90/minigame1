using UnityEngine;

/*-------------------------------------------------
#   File Name: gameManager.cs
#   Date: 10/4/2025
#   Author: Guilherme Oliveira
#
#   Desc: Keeps track game score and player Lives
-------------------------------------------------*/
public class gameManager : MonoBehaviour
{
    //----Variables----
    private int score = 0;
    private int lives = 3;

    public void calculateLives(int value)
    {
        lives += value;

        if (lives < 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}
