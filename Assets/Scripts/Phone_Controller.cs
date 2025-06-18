using UnityEngine;

public class Phone_Controller : MonoBehaviour
{
    public Sprite status1;
    public Sprite status2;
    public Sprite status3;

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
            Message_Model.is_checked = true;
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
        if (GameObject.Find("SNB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("SNB").GetComponent<Input_Handler>().Action=false;
            Screen_Changer.Change_Screen(7);
        }

        if (GameObject.Find("Status_Button1").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Status_Button1").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(10);
            GameObject.Find("Status_BG").GetComponent<SpriteRenderer>().sprite = status1;
        }
        if (GameObject.Find("Status_Button2").GetComponent<Input_Handler>().Action && GameObject.Find("Locks").transform.GetChild(0).GetComponent<SpriteRenderer>().sprite == null)
        {
            GameObject.Find("Status_Button2").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(10);
            GameObject.Find("Status_BG").GetComponent<SpriteRenderer>().sprite = status2;
        }
        if (GameObject.Find("Status_Button3").GetComponent<Input_Handler>().Action && GameObject.Find("Locks").transform.GetChild(1).GetComponent<SpriteRenderer>().sprite == null)
        {
            GameObject.Find("Status_Button3").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(10);
            GameObject.Find("Status_BG").GetComponent<SpriteRenderer>().sprite = status3;
        }
    }
}
