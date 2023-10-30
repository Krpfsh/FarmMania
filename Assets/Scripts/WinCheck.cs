using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinCheck : MonoBehaviour
{
    [SerializeField] private TMP_Text textMeshPro;
    [SerializeField] private TMP_Text scoreGameOverPlayer1;
    [SerializeField] private TMP_Text scoreGameOverPlayer2;

    private void Awake()
    {
        scoreGameOverPlayer1.text = ScoreManager.ScorePlayer1.ToString();
        scoreGameOverPlayer2.text = ScoreManager.ScorePlayer2.ToString();
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("language") == 1)
        {
            if (ScoreManager.ScorePlayer1 > ScoreManager.ScorePlayer2)
            {
                textMeshPro.color = Color.red;
                textMeshPro.text = "Win";
            }
            else if (ScoreManager.ScorePlayer1 < ScoreManager.ScorePlayer2)
            {
                textMeshPro.color = Color.blue;
                textMeshPro.text = "Win";
            }
            else
            {
                textMeshPro.color = Color.white;
                textMeshPro.text = "Draw";
            }
        }
        else
        {
            if (ScoreManager.ScorePlayer1 > ScoreManager.ScorePlayer2)
            {
                textMeshPro.color = Color.red;
                textMeshPro.text = "Выиграл";
            }
            else if (ScoreManager.ScorePlayer1 < ScoreManager.ScorePlayer2)
            {
                textMeshPro.color = Color.blue;
                textMeshPro.text = "Выиграл";
            }
            else
            {
                textMeshPro.color = Color.white;
                textMeshPro.text = "Ничья";
            }
        }


    }
}
