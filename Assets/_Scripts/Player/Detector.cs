using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverScreen;

    private void Update()
    {
        if (transform.position.y < -1.5f)
        {
            Time.timeScale = 0;
            _gameOverScreen.SetActive(true);
        }
    }
}
