using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Main_View : MonoBehaviour
{
    public GameObject Message_Screen;
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
        Player.fields.money_display.SetText(Player.fields.money.ToString());
    }
}
