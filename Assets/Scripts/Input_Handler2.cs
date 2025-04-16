using System;
using UnityEngine;

public class Input_Handler2 : MonoBehaviour
{
    public static bool Action { get; set; } = false;

    public static bool Input_Check()
    {
        if (Input.touchCount > 0 || Action==true)
        {
            Action = false;
            return true;
        }
        return false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input_Check();
    }

    private void OnMouseDown()
    {
        Action = true;
    }
}
