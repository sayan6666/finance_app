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
        if (Message_Model.dialogue[message-1].type==0 && GameObject.Find("Next_Button").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Next_Button").GetComponent<Input_Handler>().Action=false;
            Message_Model.AddMessage(Message_Model.dialogue[message].text,4, Message_Model.dialogue[message].side, true);
            message++;
        }
        timer+=Time.deltaTime;
        if (Message_Model.dialogue[message - 1].type != 1)
            timer = 0;
        if (timer>=3 && Message_Model.dialogue[message-1].type == 1)
        {
            Message_Model.AddMessage(Message_Model.dialogue[message].text, 4, Message_Model.dialogue[message].side, true);
            message++;
            timer = 0;
        }
        if (Message_Model.dialogue[message-1].type==2)
        {
            if (GameObject.Find("a").GetComponent<Input_Handler>().Action)
            {
                if (message+1==30)
                {
                    Message_Model.AddMessage(Message_Model.dialogue[message].text, 4, Message_Model.dialogue[message].side, true);
                    message++;
                }
                GameObject.Find("a").GetComponent<Input_Handler>().Action = false;
            }
            if (GameObject.Find("b").GetComponent<Input_Handler>().Action)
            {
                if (message + 1 == 20 || message + 1 == 22 || message + 1 == 26 || message+1==28 || message+1==32 || message+1==34 || message+1==36)
                {
                    Message_Model.AddMessage(Message_Model.dialogue[message].text, 4, Message_Model.dialogue[message].side, true);
                    message++;
                }
                GameObject.Find("b").GetComponent<Input_Handler>().Action=false;
            }
            if (GameObject.Find("c").GetComponent<Input_Handler>().Action)
            {
                if (message + 1 == 24 || message+1==38)
                {
                    Message_Model.AddMessage(Message_Model.dialogue[message].text, 4, Message_Model.dialogue[message].side, true);
                    message++;
                }
                GameObject.Find("c").GetComponent<Input_Handler>().Action = false;
            }
            if (GameObject.Find("d").GetComponent<Input_Handler>().Action)
            {
                GameObject.Find("d").GetComponent<Input_Handler>().Action = false;
            }
        }
        if (Message_Model.dialogue[message-1].type==3 && Task_Model.firstsstock.done==true && message==18)
        {
            Message_Model.AddMessage(Message_Model.dialogue[message].text, 4, Message_Model.dialogue[message].side, false);
            message++;
        }
        if (Message_Model.dialogue[message-1].type==3 && message==39 && Player.fields.status>1)
        {
            Message_Model.AddMessage(Message_Model.dialogue[message].text, 4, Message_Model.dialogue[message].side, true);
            message++;
        }
        if (Message_Model.dialogue[message-1].type==3 && message==41 && Main_Model.GreenPower.fields.amount>=1)
        {
            Message_Model.AddMessage(Message_Model.dialogue[message].text, 4, Message_Model.dialogue[message].side, true);
            message++;
        }

        if (GameObject.Find("scroll").transform.GetChild(1).GetComponent<Input_Handler>().Action)
        {
            var py = GameObject.Find("Message_Origin").transform.localPosition.y;
            GameObject.Find("Message_Origin").transform.SetLocalPositionAndRotation(new Vector3(GameObject.Find("Message_Origin").transform.localPosition.x,py+2, 0),new Quaternion(0,0,0,0));
            var py1 = GameObject.Find("Messages").transform.localPosition.y;
            GameObject.Find("Messages").transform.SetLocalPositionAndRotation(new Vector3(GameObject.Find("Messages").transform.localPosition.x, py1 + 2, 0), new Quaternion(0, 0, 0, 0));
        }
        if (GameObject.Find("scroll").transform.GetChild(0).GetComponent<Input_Handler>().Action)
        {
            var py = GameObject.Find("Message_Origin").transform.localPosition.y;
            GameObject.Find("Message_Origin").transform.SetLocalPositionAndRotation(new Vector3(GameObject.Find("Message_Origin").transform.localPosition.x, py - 2, 0), new Quaternion(0, 0, 0, 0));
            var py1 = GameObject.Find("Messages").transform.localPosition.y;
            GameObject.Find("Messages").transform.SetLocalPositionAndRotation(new Vector3(GameObject.Find("Messages").transform.localPosition.x, py1 - 2, 0), new Quaternion(0, 0, 0, 0));
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
        Player.fields.last_message = message;
    }
}
