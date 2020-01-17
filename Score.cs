using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameManagerScript gm;
    public TMP_Text scoreText;
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManagerScript.money.ToString();
    }
}
