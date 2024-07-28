using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMenu : MonoBehaviour
{
    public Button backButton; // Assign the back button in the Unity editor

    private void Start()
    {
        backButton.onClick.AddListener(LoadMainMenu); // Add a listener for the back button click event
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); // Load the main menu scene

        // Get the scene name of the "CreditScene" scene
        string creditSceneName = "CreditScene";

        // Unload the "CreditScene" scene
        SceneManager.UnloadSceneAsync(creditSceneName);
    }
}