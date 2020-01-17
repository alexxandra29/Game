using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        collisionFinal.traseuTerminat = false;
        GameManagerScript.money = 0;
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
