using UnityEngine;

public class Resize : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    [Tooltip("The size of the change on X axis")]
    private float X = 0.5f;

    [SerializeField]
    [Tooltip("The size of the change on Y axis")]
    private float Y = 0.5f;

    [SerializeField]
    [Tooltip("The size of the change on Z axis")]
    private float Z = 0.5f;

    [SerializeField]
    [Tooltip("Maximum size")]
    private float MaximumSize = 8f;

    [SerializeField]
    [Tooltip("Minimum size")]
    private float MinimumSize = 1f;

    private int flag = 1;

    // Update is called once per frame
    private void Update()
    {
        transform.localScale += new Vector3(X, Y, Z) * Time.deltaTime * flag;

        if (transform.localScale.x > MaximumSize || transform.localScale.x < MinimumSize)
        {
            flag *= -1;
        }
    }
}
