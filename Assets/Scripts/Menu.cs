using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button playButton; // Assign the play button in the Unity editor

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame); // Add a listener for the button click event
    }

    public void PlayGame()
    {
        StartCoroutine(UnloadMainMenu()); // Unload the main menu scene after a short delay
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single); // Load the game scene and unload the previous scene

        // Log the state of each scene before loading the game scene
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            Debug.Log($"Scene: {scene.name}, IsLoaded: {scene.isLoaded}");
        }
    }

    private IEnumerator UnloadMainMenu()
    {
        yield return new WaitForSeconds(0.1f); // Wait for a short period of time
        SceneManager.UnloadSceneAsync("MainMenu"); // Unload the main menu scene

        // Log the state of each scene after unloading the main menu scene
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            Debug.Log($"Scene: {scene.name}, IsLoaded: {scene.isLoaded}");
        }
    }

    public void SelectLevel()
    {
        // Implement level selection logic here, such as loading a level selection scene or displaying a list of levels
    }

    public void Credits()
    {
        // Implement credits logic here, such as loading a credits scene or panel
    }

    public void Quit()
    {
        Application.Quit();
    }
}