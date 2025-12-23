using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject ScoreCanvas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1f;    
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        ScoreCanvas.SetActive(false);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void EngGame()
    {
        Application.Quit();
    }

   
}
