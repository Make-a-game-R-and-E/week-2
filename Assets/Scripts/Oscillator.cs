using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("the range of the amplitude - range from the start position to right and left")]
    float amplitude = 5f;
    [SerializeField]
    [Tooltip("how long will take the object to do 'go and back' - affects the speed of the object, the higher - the faster")]
    float frequency = 0.25f;

    private float startX; // starting X position    

    void Start()
    {
        // Store the initial X position
        startX = transform.position.x;
    }

    void Update()
    {
        // Calculate the new X position using a cosine function for smooth oscillation
        float x = startX + amplitude * Mathf.Cos(Mathf.PI * frequency * Time.time);

        // Apply the new position, keeping Y and Z unchanged
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
