using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    [SerializeField] private GameObject instructionGameObject;
    
    // Start is called before the first frame update
    void Start()
    { 
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        instructionGameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
