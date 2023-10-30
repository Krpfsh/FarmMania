using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    [SerializeField] private int _timeBetweenGrowths;
    [SerializeField] private int _maxGrowth;
    private int _currentProgression = 0;
    private void Start()
    {
        InvokeRepeating("Growth", _timeBetweenGrowths, _timeBetweenGrowths);
    }
    public void Growth()
    {
        if(_currentProgression!= _maxGrowth)
        {
            gameObject.transform.GetChild(_currentProgression).gameObject.SetActive(true);
        }
        if(_currentProgression>0 && _currentProgression< _maxGrowth)
        {
            gameObject.transform.GetChild(_currentProgression-1).gameObject.SetActive(false);
        }
        if (_currentProgression < _maxGrowth)
        {
            _currentProgression++;
        }
    }
}
