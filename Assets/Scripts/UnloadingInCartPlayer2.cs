using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnloadingInCartPlayer2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player2" && Backpack.FruitsPlayer2 != 0)
        {
            ScoreManager.ScorePlayer2 += Backpack.FruitsPlayer2;
            Backpack.FruitsPlayer2 = 0;
        }
    }
}
