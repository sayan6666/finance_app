using UnityEngine;

public class Message_Controller : MonoBehaviour
{
    private bool flag=false;
    public static int message=1;
    public static float timer = 0;
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
        if (Message_Model.dialogue[message-1].Item3==0 && GameObject.Find("Next_Button").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Next_Button").GetComponent<Input_Handler>().Action=false;
            Message_Model.AddMessage(Message_Model.dialogue[message].Item1,4, Message_Model.dialogue[message].Item2, true);
            message++;
        }
        timer+=Time.deltaTime;
        if (Message_Model.dialogue[message - 1].Item3 != 1)
            timer = 0;
        if (timer>=3 && Message_Model.dialogue[message-1].Item3 == 1)
        {
            Message_Model.AddMessage(Message_Model.dialogue[message].Item1, 4, Message_Model.dialogue[message].Item2, true);
            message++;
            timer = 0;
        }

        if (GameObject.Find("scroll").transform.GetChild(1).GetComponent<Input_Handler>().Action)
        {
            var py = GameObject.Find("Message_Origin").transform.localPosition.y;
            GameObject.Find("Message_Origin").transform.SetLocalPositionAndRotation(new Vector3(GameObject.Find("Message_Origin").transform.localPosition.x,py+2, GameObject.Find("Message_Origin").transform.position.z),new Quaternion(0,0,0,0));
        }
        if (GameObject.Find("scroll").transform.GetChild(0).GetComponent<Input_Handler>().Action)
        {
            var py = GameObject.Find("Message_Origin").transform.localPosition.y;
            GameObject.Find("Message_Origin").transform.SetLocalPositionAndRotation(new Vector3(GameObject.Find("Message_Origin").transform.localPosition.x, py - 2, GameObject.Find("Message_Origin").transform.position.z), new Quaternion(0, 0, 0, 0));
        }

        if (GameObject.Find("Exit_Message_Button").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Exit_Message_Button").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(2);

            /*flag = false;
            
            Message_Model.Buttons_Active();
            Main_Model.Screen_Active();*/
        }
        if (GameObject.Find("MSB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("MSB").GetComponent<Input_Handler>().Action=false;
            Screen_Changer.Change_Screen(3);
        }
        if (GameObject.Find("MNB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("MNB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(7);
        }
        if (GameObject.Find("MTB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("MTB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(6);
        }
        GameObject.Find("scroll").transform.GetChild(0).GetComponent<Input_Handler>().Action = false;
        GameObject.Find("scroll").transform.GetChild(1).GetComponent<Input_Handler>().Action = false;
    }
}
