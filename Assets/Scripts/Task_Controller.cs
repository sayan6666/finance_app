using UnityEngine;

public class Task_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Task_Model.Exit_Action.Action)
        {
            Task_Model.Exit_Action.Action = false;
            Screen_Changer.Change_Screen(3);
        }
        if (GameObject.Find("TCB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("TCB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(2);
        }
        if (GameObject.Find("TNB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("TNB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(7);
        }
        if (GameObject.Find("TMB").GetComponent<Input_Handler>().Action)
        {
            Message_Model.is_checked = true;
            GameObject.Find("TMB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(4);
        }
        if (GameObject.Find("Task1").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Task1").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(9);
            Task_Model.marked = 1;
        }
        if (GameObject.Find("Task2").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Task2").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(9);
            Task_Model.marked = 2;
        }
        if (GameObject.Find("Task3").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Task3").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(9);
            Task_Model.marked = 3;
        }
        if (GameObject.Find("Exit_TD_Button").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Exit_TD_Button").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(6);
        }

    }
}
