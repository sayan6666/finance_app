using UnityEngine;

public class Message_Controller : MonoBehaviour
{
    private bool flag=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Main_Model.Screen_Position!=Main_Model.Screen.transform.position && Bag_Model.Screen_Position!=Bag_Model.Screen.transform.position && flag==false)
        {
            Message_Model.Buttons_Active();
            flag = true;
        }*/
        if (GameObject.Find("Exit_Message_Button").GetComponent<Input_Handler>().Action)
        {
            Screen_Changer.Change_Screen(2);
            GameObject.Find("Exit_Message_Button").GetComponent<Input_Handler>().Action = false;
            /*flag = false;
            
            Message_Model.Buttons_Active();
            Main_Model.Screen_Active();*/
        }
    }
}
