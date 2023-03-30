using UnityEngine;
using UnityEngine.SceneManagement;

public class UIRestartButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
