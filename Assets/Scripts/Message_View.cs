using UnityEngine;

public class Message_View : MonoBehaviour
{
    public GameObject assistant;
    public Sprite sprite_normal;
    public Sprite sprite_happy;
    public Sprite sprite_sad;
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
        assistant = GameObject.Find("Assistant");
    }

    // Update is called once per frame
    void Update()
    {
        switch (Main_Model.verdict)
        {
            case 0:
                {
                    assistant.GetComponent<SpriteRenderer>().sprite = sprite_normal;
                    break;
                }
            case 1:
                {
                    assistant.GetComponent<SpriteRenderer>().sprite = sprite_happy;
                    break;
                }
            case -1:
                {
                    assistant.GetComponent<SpriteRenderer>().sprite = sprite_sad;
                    break;
                }
        }
    }
}
