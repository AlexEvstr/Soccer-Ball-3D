using UnityEngine;

public class UIStartButton : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    private Score _score;

    private void Start()
    {
        Time.timeScale = 0;
        _score = GetComponent<Score>();
    }
    public void OnClick()
    {
        _startPanel.SetActive(false);
        Time.timeScale = 1;
        _score.StartGame();
    }
}
