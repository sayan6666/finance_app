using UnityEngine;
using UnityEngine.UI;

public class Message_View : MonoBehaviour
{
    public GameObject assistant;
    public Sprite sprite_normal;
    public Sprite sprite_happy;
    public Sprite sprite_sad;
    public Sprite next;
    public Sprite vars;
    public void Phone_Screen_InActive()
    {
       /* Main_Screen.SetActive(true);
        GameObject.Find("Message_Screen").SetActive(false);
        Main_Controller.phone_active = true;*/
        //Message_Controller.phone_inactive = true;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*GameObject.Find("Next_Button").SetActive(false);
        GameObject.Find("Exit_Message_Button").SetActive(false);*/
        assistant = GameObject.Find("Messages");
    }

    // Update is called once per frame
    void Update()
    {
        switch (Main_Model.verdict)
        {
            case 0:
                {
                    for (int i=0;i<assistant.transform.childCount;i++)
                    assistant.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = sprite_normal;
                    break;
                }
            case 1:
                {
                    for (int i = 0; i < assistant.transform.childCount; i++)
                        assistant.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = sprite_happy;
                    break;
                }
            case -1:
                {
                    for (int i = 0; i < assistant.transform.childCount; i++)
                        assistant.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = sprite_sad;
                    break;
                }
        }

        if (Message_Model.dialogue[Message_Controller.message - 1].type == 2)
        {
            GameObject.Find("Bottom").GetComponent<SpriteRenderer>().sprite = vars;
            GameObject.Find("Vars").transform.SetLocalPositionAndRotation(new Vector3(0,0,0),new Quaternion(0,0,0,0));
            GameObject.Find("Next_Button").transform.SetLocalPositionAndRotation(new Vector3(2.181499f, -10, 0), new Quaternion(0, 0, 0, 0));
        }
        else
        {
            GameObject.Find("Bottom").GetComponent<SpriteRenderer>().sprite = next;
            GameObject.Find("Vars").transform.SetLocalPositionAndRotation(new Vector3(0,-10,0),new Quaternion(0,0,0,0));
            GameObject.Find("Next_Button").transform.SetLocalPositionAndRotation(new Vector3(2.181499f, -3.170002f,0),new Quaternion(0,0,0,0)); ;
        }
    }
}
