using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField]
    [Tooltip("the speed of the rotation on axis X")]
    float speedX = 50f;
    [SerializeField]
    [Tooltip("the speed of the rotation on axis Y")]
    float speedY = 50f;
    [SerializeField]
    [Tooltip("the speed of the rotation on axis Z")]
    float speedZ = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the Y axis
        transform.Rotate(Vector3.right, speedX * Time.deltaTime);
        transform.Rotate(Vector3.up, speedY * Time.deltaTime);
        transform.Rotate(Vector3.forward, speedZ * Time.deltaTime);
    }
}
