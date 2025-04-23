using TMPro;
using UnityEditor;
using UnityEngine;

public class Message_Model : MonoBehaviour
{
    public static GameObject Next_Button;
    public static GameObject Exit_Button;
    public static void Buttons_Active()
    {
        Next_Button.SetActive(!Next_Button.activeSelf);
        Exit_Button.SetActive(!Exit_Button.activeSelf);
    }
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
        Next_Button = GameObject.Find("Next_Button"); ;
        Exit_Button = GameObject.Find("Exit_Message_Button");
        AddMessage("Здравствуйте! Спасибо что решили воспользоваться моими услугами.",scripte.messages); 
        scripte.messages++;
        Message_Model.Buttons_Active();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
