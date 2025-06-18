using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Main_View : MonoBehaviour
{
    public GameObject Message_Screen;
    public Sprite sprite_normal;
    public Sprite sprite_happy;
    public Sprite sprite_sad;
    public Sprite sprite_normal_cut;
    public Sprite sprite_happy_cut;
    public Sprite sprite_sad_cut;
    public Sprite investor;
    public Sprite expert;

    public void Phone_Screen_Active()
    {
        /*GameObject.Find("Main_Screen").SetActive(false);
        Message_Screen.SetActive(true);
        Message_Controller.phone_inactive = false;*/
        //Main_Controller.phone_active = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Player.fields.money_display1.SetText(Player.fields.money.ToString()+ "₽");
        if (!Message_Model.is_checked)
        {
            Main_Model.assistant.transform.SetLocalPositionAndRotation(new Vector3(Main_Model.assistant.transform.localPosition.x, -0.6f, Main_Model.assistant.transform.localPosition.z), new Quaternion(0,0,0,0));
        }
        else
            Main_Model.assistant.transform.SetLocalPositionAndRotation(new Vector3(Main_Model.assistant.transform.localPosition.x, -3.5f, Main_Model.assistant.transform.localPosition.z), new Quaternion(0, 0, 0, 0));
        switch (Main_Model.verdict)
        {
            case 0:
                {
                    Main_Model.assistant.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = sprite_normal_cut;
                    break;
                }
            case 1:
                {
                    Main_Model.assistant.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = sprite_happy_cut;
                    break;
                }
            case -1:
                {
                    Main_Model.assistant.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = sprite_sad_cut;
                    break;
                }
        }
        switch(Player.fields.status)
        {
            case 1:
                {
                    GameObject.Find("Status_Overlay_Main").GetComponent<SpriteRenderer>().sprite = null;
                    break;
                }
            case 2:
                {
                    GameObject.Find("Status_Overlay_Main").GetComponent<SpriteRenderer>().sprite = investor;
                    break;
                }
            case 3:
                {
                    GameObject.Find("Status_Overlay_Main").GetComponent<SpriteRenderer>().sprite = expert;
                    break;
                }
        }
    }
}
