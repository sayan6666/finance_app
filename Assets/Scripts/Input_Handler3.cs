using System;
using UnityEngine;

public class Input_Handler3 : MonoBehaviour
{
    public bool Action { get; set; } = false;
    
    public bool Input_Check()
    {
        if (Input.touchCount > 0 || Action == true)
        {
            Debug.Log("++");
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
        Action = false;
    }

    private void OnMouseDown()
    {
        Action = true;
    }
}
