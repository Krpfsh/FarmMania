using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScore : MonoBehaviour
{
    [SerializeField] private int _scoreFruit;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("AudioSourcePickUpFruits").GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player1" && gameObject.name == "Fruit3" && Backpack.FruitsPlayer1 != Backpack.sizeBackpackPlayer1 && _scoreFruit <=( Backpack.sizeBackpackPlayer1- Backpack.FruitsPlayer1))
        {
            Backpack.FruitsPlayer1+=_scoreFruit;
            audioSource.Play();
            Destroy(transform.parent.gameObject);
        }
        if (collision.gameObject.name == "Player2" && gameObject.name == "Fruit3" && Backpack.FruitsPlayer2 != Backpack.sizeBackpackPlayer2 && _scoreFruit <= (Backpack.sizeBackpackPlayer2 - Backpack.FruitsPlayer2))
        {
            Backpack.FruitsPlayer2+=_scoreFruit;
            audioSource.Play();
            Destroy(transform.parent.gameObject);
        }

    }
}
