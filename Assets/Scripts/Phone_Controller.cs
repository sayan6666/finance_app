using UnityEngine;

public class Phone_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Phone_Model.Message_Action.Action)
        {
            Phone_Model.Message_Action.Action = false;
            Screen_Changer.Change_Screen(4);
        }
        if (Phone_Model.Task_Action.Action)
        {
            Phone_Model.Task_Action.Action = false;
            Screen_Changer.Change_Screen(6);
        }
        if (Phone_Model.Exit_Action.Action)
        {
            Phone_Model.Exit_Action.Action = false;
            Screen_Changer.Change_Screen(2);
        }
    }
}
