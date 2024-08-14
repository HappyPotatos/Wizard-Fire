using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button playButton; // Assign the play button in the Unity editor
    public Button quitButton; // Assign the quit button in the Unity editor
    public Button creditsButton; // Assign the credits button in the Unity editor

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame); // Add a listener for the play button click event
        quitButton.onClick.AddListener(QuitGame); // Add a listener for the quit button click event
        creditsButton.onClick.AddListener(OpenCreditsScene); // Add a listener for the credits button click event
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single); // Load the game scene and unload the previous scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenCreditsScene()
    {
        SceneManager.LoadScene("CreditScene", LoadSceneMode.Single); // Load the credit scene
    }
}