using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordFruits : MonoBehaviour
{
    [SerializeField] private TMP_Text recordTMpro;
    private float _record;
    private void Start()
    {
        _record = ScoreManager.ScorePlayer1 + ScoreManager.ScorePlayer2;
        if (_record > PlayerPrefs.GetFloat("RecordFruits"))
        {
            PlayerPrefs.SetFloat("RecordFruits", _record);
        }
        recordTMpro.text = PlayerPrefs.GetFloat("RecordFruits").ToString();
    }
}
