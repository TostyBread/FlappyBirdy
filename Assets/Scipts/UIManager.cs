using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _retryButton;//this button will show up when selected
    [SerializeField] private GameObject _mainmenuButton;//this button will show up when selected
    [SerializeField] private TMP_Text _score;//for score display

    private void Awake()
    {
        FlappyBird.OnDeath += OnGameOver;
        FlappyBird.OnScore += OnScore;
    }

    private void OnDestroy()
    {
        FlappyBird.OnDeath -= OnGameOver;
        FlappyBird.OnScore -= OnScore;
    }

    public void RestartGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    public void ExitMainMenu() => SceneManager.LoadScene("MainMenu");

    private void OnGameOver()
    {
        _retryButton.SetActive(true);//when DaPlane crashed, button became active
        _mainmenuButton.SetActive(true);//when DaPlane crashed, button became active
    }
    private void OnScore() => _score.text = (int.Parse(_score.text) + 1).ToString();
}
