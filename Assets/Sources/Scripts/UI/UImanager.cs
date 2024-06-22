using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField]private GameObject _startButton;
    private void Start()
    {
        _startButton.SetActive(true);
        Time.timeScale = 0;
    }
    public void Show(GameObject _gameObject)
    {
        _gameObject.SetActive(true);
    }


    public void Hide(GameObject _gameObject)
    {
        _gameObject.SetActive(false);
    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void StartButton()
    {
        Time.timeScale = 1;
        _startButton.SetActive(false);

    }

}


   

