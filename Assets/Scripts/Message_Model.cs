using SQLite4Unity3d;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

[Table("Messages")]
public class Message
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int id { get; set; }
    [Column("text")]
    public string text { get; set; }
    [Column("side")]
    public string side { get; set; }
    [Column("type")]
    public int type { get; set; }
}

public class Message_Model : MonoBehaviour
{
    public static GameObject Next_Button;
    public static GameObject Exit_Button;
    public static bool is_checked;
    public static List<Message> dialogue;
    public static double prev_height;

    public static void Buttons_Active()
    {
        Next_Button.SetActive(!Next_Button.activeSelf);
        Exit_Button.SetActive(!Exit_Button.activeSelf);
    }
    public static void AddMessage(string message, int amount, string align, bool seen)
    {
        Transform New_Avatar;
        prev_height = GameObject.Find("Message_Origin").GetComponent<RectTransform>().rect.height;
        is_checked = seen;
        if (amount == 0)
        {
            GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().SetText("<align=" + align + ">" + message + "\n");
        }
        else
        {
            GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().SetText(GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().text + "\n\n" + $"<align={align}>" + message);
        }
        if (amount != 0 && align == "left")
        {
            New_Avatar = GameObject.Instantiate(GameObject.Find("Messages").transform.GetChild(0));
            New_Avatar.transform.SetParent(GameObject.Find("Messages").transform);
            New_Avatar.transform.localScale = Vector3.one;
            New_Avatar.name = "Assistant";
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue = new List<Message>();
        CreateDialogue();
        is_checked = false;
        Next_Button = GameObject.Find("Next_Button"); ;
        Exit_Button = GameObject.Find("Exit_Message_Button");
        AddMessage(dialogue[0].text,0, "left", false); 
        scripte.messages++;
        if (Player.fields.last_message > 1)
            for (int i = 2; i < Player.fields.last_message; i++)
                AddMessage(dialogue[i].text, 4, dialogue[i].side, true);
        Message_Controller.message=Player.fields.last_message;
    }

    /*0 - ожидание кнопкт далее
     1 - задрежка 1 секунда
    2 - ожидание выбора
    3 - конец*/
    public void CreateDialogue()
    {
        for (int i = 1; i < 45; i++)
            dialogue.Add(DB_Handler.connection.Table<Message>().Where(t => t.id==i).FirstOrDefault());
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue[Message_Controller.message - 1].side == "left")
        {
            double y = -(prev_height + (((double)GameObject.Find("Message_Origin").GetComponent<RectTransform>().rect.height - prev_height) / 2d));
            GameObject.Find("Messages").transform.GetChild(GameObject.Find("Messages").transform.childCount - 1).transform.SetLocalPositionAndRotation(new Vector3(-2.546351f, (float)y, 0), new Quaternion(0, 0, 0, 0));
        }
    }
}
