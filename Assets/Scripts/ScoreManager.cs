using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _scorePlayer1;
    [SerializeField] private TMP_Text _scorePlayer2;
    public static float ScorePlayer1 = 0;
    public static float ScorePlayer2 = 0;

    private void Update()
    {
        _scorePlayer1.text = ScorePlayer1.ToString();
        _scorePlayer2.text = ScorePlayer2.ToString();
    }
}
