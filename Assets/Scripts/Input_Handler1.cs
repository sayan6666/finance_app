using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Input_Handler : MonoBehaviour
{
    public bool Action { get; set; } = false;
    /*public static InputActionAsset actionAsset;
    public static InputActionMap inputActions = actionAsset.FindActionMap("Player");
    public InputAction action = inputActions.FindAction("Buy");*/
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetTouch(0).phase==UnityEngine.TouchPhase.Began)
        {
            Action = true;
        }*/
    }

    private void OnMouseDown()
    {
        Action = true;
    }
}
