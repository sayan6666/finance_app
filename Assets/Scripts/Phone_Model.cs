using UnityEngine;

public class Phone_Model : MonoBehaviour
{
    public static Input_Handler Message_Action;
    public static Input_Handler Task_Action;
    public static Input_Handler Exit_Action;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Message_Action = GameObject.Find("Phone_Real_Button").GetComponent<Input_Handler>();
        Task_Action = GameObject.Find("Task_Button").GetComponent<Input_Handler>();
        Exit_Action = GameObject.Find("Exit_Phone_Button").GetComponent<Input_Handler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
