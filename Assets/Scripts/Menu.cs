using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Replace "GameScene" with the name of your game scene
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