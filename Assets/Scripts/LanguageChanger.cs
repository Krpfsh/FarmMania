using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LanguageChanger : MonoBehaviour
{
    public int language;
    public string[] text;
    private TMP_Text textLine;


    void Update()
    {
        language = PlayerPrefs.GetInt("language", language); //��������� ����
        textLine = GetComponent<TMP_Text>(); //���������� � ����������
        textLine.text = "" + text[language]; //��������� ����� ����� ����� ������������, � ����������� ������������ �����
    }
    
}