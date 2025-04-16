using TMPro;
using UnityEngine;

public class Message_Model : MonoBehaviour
{
    public static void AddMessage(string message, int amount)
    {
        var New_Message = GameObject.Instantiate(GameObject.Find("Message_Origin"));
        New_Message.transform.SetParent(GameObject.Find("Message_Screen").transform, true);
        New_Message.GetComponent<TextMeshPro>().SetText(message);
        var Pos_Rot = GameObject.Find("Message_Origin").GetComponent<Transform>();
        New_Message.GetComponent<Transform>().SetPositionAndRotation(new Vector3(Pos_Rot.position.x,Pos_Rot.position.y-amount, Pos_Rot.position.z),new Quaternion(0,0,0,0));
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Message_Controller.phone_inactive==false)
        {
            GameObject.Find("Message_Screen").GetComponent<Message_View>().Phone_Screen_InActive();
        }
    }
}
