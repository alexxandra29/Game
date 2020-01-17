using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionFinal : MonoBehaviour
{
    public Collider2D finalCollider2D;

    public static bool traseuTerminat = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider == finalCollider2D)
        {
            traseuTerminat = true;
            SceneManager.LoadScene(2);
        }
    }
  
}
