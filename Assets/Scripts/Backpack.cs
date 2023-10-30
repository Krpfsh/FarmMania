using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Backpack : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _fruitsInBackPackPlayer1;
    [SerializeField] private TextMeshProUGUI _fruitsInBackPackPlayer2;
    public static int FruitsPlayer1 = 0;
    public static int sizeBackpackPlayer1 = 5;
    public static int sizeBackpackPlayer2 = 5;
    public static int FruitsPlayer2 = 0;

    private void Update()
    {
        _fruitsInBackPackPlayer1.text = FruitsPlayer1.ToString() + "/" + sizeBackpackPlayer1;
        _fruitsInBackPackPlayer2.text = FruitsPlayer2.ToString() + "/" + sizeBackpackPlayer2;
    }
}
