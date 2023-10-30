using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timeText;
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private float timeStart = 6;
    [SerializeField] private GameObject audioSourceTimer;
    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    private void Update()
    {
        if (Mathf.Round(timeStart) != 0)
        {
            timeStart -= Time.deltaTime;
            _timeText.text = Mathf.Round(timeStart).ToString();
        }
        else
        {
            Time.timeScale = 0f;
            _gameOver.SetActive(true);
        }
        if (Mathf.Round(timeStart) <= 10&& Mathf.Round(timeStart) >= 4) _timeText.color = Color.yellow;
        if (Mathf.Round(timeStart) <= 3)
        {
            audioSourceTimer.SetActive(true);
            _timeText.color = Color.red;
        }
    }
}