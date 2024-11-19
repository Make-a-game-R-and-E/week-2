using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField]
    InputAction action = new InputAction("action", type: InputActionType.Button, "<Keyboard>/space");
    
    private void OnEnable()
    {
        action.Enable(); 
    }

    private void OnDisable()
    {
        action.Disable();
    }

    void Update()
    {
        if (action.WasPressedThisFrame())
        {
            SpriteRenderer SR = GetComponent<SpriteRenderer>();
            SR.enabled = !SR.enabled;
        }
    }
}
