using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Function to exit the game
    public void QuitGame()
    {
        // Exit Play Mode in the Unity Editor
        UnityEditor.EditorApplication.isPlaying = false;
        // Close the application
        Application.Quit();
    }
}
