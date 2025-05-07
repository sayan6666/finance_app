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
    }
}
