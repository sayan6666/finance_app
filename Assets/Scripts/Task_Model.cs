using UnityEngine;

public class Task_Model : MonoBehaviour
{
    public static Input_Handler Exit_Action;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Exit_Action = GameObject.Find("Exit_Button").GetComponent<Input_Handler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
