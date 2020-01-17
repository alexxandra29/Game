using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    static public float money = 0;

    public void CoinCollected()
    {
        money += 1;
    }
}
