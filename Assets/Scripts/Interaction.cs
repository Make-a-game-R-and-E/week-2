using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField]
    private InputAction action = new InputAction("action", type: InputActionType.Button, binding: "<Keyboard>/space");

    private void OnEnable()
    {
        action.Enable();
    }
    private void OnDisable()
    {
        action.Disable();
    }

    private void Update()
    {
        if (action.WasPressedThisFrame())
        {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            sr.enabled = !sr.enabled;
        }
    }
}
