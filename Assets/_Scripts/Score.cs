using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Score : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private TMP_Text _distanceText;
    private int _distance;

    public void StartGame()
    {
        _distance = 0;
        StartCoroutine(IncreaseDistance());
    }

    public IEnumerator IncreaseDistance()
    {
       while(true)
        {
            _distance++;
            _distanceText.text = _distance.ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }
}

