using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private int _numberScene;
    public void OnButtonClick()
    {
        
        SceneManager.LoadScene(_numberScene);
        
    }
}
