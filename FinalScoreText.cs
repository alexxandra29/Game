using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScoreText : MonoBehaviour
{
    // public GameManagerScript gm;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    float timpRealscore = 0, score = 0;
    static public float highScore = 0;
    // Update is called once per frame
    void Update()
    {
        if (collisionFinal.traseuTerminat == true)
        {
            verificaScorul();
        }
    }
    public void verificaScorul()
    {
        timpRealscore = GameManagerScript.money;
        if (timpRealscore > score)
        {
            score = timpRealscore;
        }
        if (timpRealscore > highScore)
        {
            highScore = timpRealscore;
        }
        scoreText.text = "SCORE : " + score.ToString();
        highScoreText.text = "HIGHSCORE : " + highScore.ToString();
        GameManagerScript.money = 0;
    }
}
