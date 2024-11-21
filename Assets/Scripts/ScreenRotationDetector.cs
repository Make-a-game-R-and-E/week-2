using UnityEngine;

public class ScreenRotationDetector : MonoBehaviour
{
    // Stores the last known screen orientation to detect changes
    private ScreenOrientation lastOrientation;
    // Reference to the Camera component attached to this GameObject
    private Camera _camera;
    // Desired scene area (width * height), maintaining a 16:9 aspect ratio
    private float desiredSceneArea = 16f * 9f;

    void Start()
    {
        // Store the initial screen orientation
        lastOrientation = Screen.orientation;
        Debug.Log("Initial Screen Orientation: " + lastOrientation);

        // Get the Camera component
        _camera = GetComponent<Camera>();
        if (_camera == null)
        {
            Debug.LogError("No Camera component found! Attach this script to a GameObject with a Camera.");
            return;
        }
        // Adjust the camera's orthographic size based on the initial screen setup
        AdjustCameraSize();
    }

    void Update()
    {
        // Check if the screen orientation has changed
        if (Screen.orientation != lastOrientation)
        {
            // Update the last known orientation
            lastOrientation = Screen.orientation;
            Debug.Log("Screen Orientation Changed: " + lastOrientation);
            // Adjust the camera size for the new orientation
            AdjustCameraSize();
        }
    }

    void AdjustCameraSize()
    {
        // Calculate the screen area in pixels squared
        float screenArea = Screen.width * Screen.height;
        // Compute the ratio between the desired scene area and the actual screen area
        float ratio = Mathf.Sqrt(desiredSceneArea / screenArea);
        // Calculate the desired half-height for the camera's orthographic size
        float desiredHalfHeight = 0.5f * ratio * Screen.height;
        // Set the camera's orthographic size to the calculated half-height
        _camera.orthographicSize = desiredHalfHeight;
    }
}
