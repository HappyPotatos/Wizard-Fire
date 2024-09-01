using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public string pauseSceneName = "PauseMenu"; // Replace with the name of your pause scene

    private bool _isPaused = false;

    void Start()
    {
        // Load the pause scene
        SceneManager.LoadScene(pauseSceneName, LoadSceneMode.Additive);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(pauseSceneName));
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Listen for a left mouse button click
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        _isPaused = !_isPaused;

        if (_isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f; // Pause the game
        AudioListener.pause = true; // Pause the audio
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f; // Resume the game
        AudioListener.pause = false; // Resume the audio
    }
}