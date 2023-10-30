using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UnloadingInCartPlayer1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player1" && Backpack.FruitsPlayer1 != 0)
        {
            ScoreManager.ScorePlayer1 += Backpack.FruitsPlayer1;
            Backpack.FruitsPlayer1 = 0;
        }
    }
}
