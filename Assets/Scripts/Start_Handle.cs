using System;
using UnityEngine;

public class Start_Handle : MonoBehaviour
{
    public static bool Action { get; set; } = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Action = false; Õ≈ ¬ Àﬁ◊¿“‹!
    }

    void OnMouseDown()
    {
        Action = true;
        Debug.Log(Action);
    }
}
