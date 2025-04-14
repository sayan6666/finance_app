using UnityEngine;

public class Input_Handler : MonoBehaviour
{
    public bool Action { get; set; } = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0)
        {
            Action = true;
        }
    }

    private void OnMouseDown()
    {
        Action = true;
    }
}
