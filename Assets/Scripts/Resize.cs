using UnityEngine;

public class Resize : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    [Tooltip("the size of the change on X axis")]
    float X = 0.5f;
    [SerializeField]
    [Tooltip("the size of the change on Y axis")]
    float Y = 0.5f;
    [SerializeField]
    [Tooltip("the size of the change on Z axis")]
    float Z = 0.5f;
    [SerializeField]
    [Tooltip("maximum size")]
    float MaximumSize = 8f;
    [SerializeField]
    [Tooltip("minimum size")]
    float MinimumSize = 1f;
    int flag = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(X, Y, Z) * Time.deltaTime * flag;
        if (transform.localScale.x > MaximumSize || transform.localScale.x < MinimumSize)
        {
            flag *= -1;
        }
    }
}
