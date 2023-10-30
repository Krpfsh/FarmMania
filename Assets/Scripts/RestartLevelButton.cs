using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLevelButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        ScoreManager.ScorePlayer1 = 0;
        ScoreManager.ScorePlayer2 = 0;
        Backpack.FruitsPlayer1 = 0;
        Backpack.FruitsPlayer2 = 0;
        Backpack.sizeBackpackPlayer1 = 5;
        Backpack.sizeBackpackPlayer2 = 5;
        DontDestroyOnLoad(GameObject.Find("MusicBG"));
        SceneManager.LoadScene("Game");
    }
}
