using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageButtons : MonoBehaviour
{
    public int language;
    void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
    }
        public void RussianLanguage()
    {
        language = 0;
        PlayerPrefs.SetInt("language", language);
    }

    public void EnglishLanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("language", language);
    }
}
