using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private int bonusId;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("AudioSourcePickUpBonus").GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            switch (bonusId)
            {
                case 0:
                    ScoreManager.ScorePlayer1 += 10;
                    audioSource.Play();
                    break;
                case 1:
                    PlayerControllerWASD.speed += 20;
                    audioSource.Play();
                    break;
                case 2:
                    Backpack.sizeBackpackPlayer1+=3;
                    audioSource.Play();
                    break;
                default:
                    break;
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Player2")
        {
            switch (bonusId)
            {
                case 0:
                    ScoreManager.ScorePlayer2 += 10;
                    audioSource.Play();
                    break;
                case 1:
                    PlayerControllerArrows.speed += 20;
                    audioSource.Play();
                    break;
                case 2:
                    Backpack.sizeBackpackPlayer2+=3;
                    audioSource.Play();
                    break;
                default:
                    break;
            }
            Destroy(gameObject);
        }
    }
}
