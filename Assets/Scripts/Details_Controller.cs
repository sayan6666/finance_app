using UnityEngine;

public class Details_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Exit_Details_Button").GetComponent<Input_Handler>().Action)
        {  
            Screen_Changer.Change_Screen(Details_Model.previous_screen);
            GameObject.Find("Exit_Details_Button").GetComponent<Input_Handler>().Action = false;
        }

        if (GameObject.Find("DCB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("DCB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(2);
        }
        if (GameObject.Find("DSB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("DSB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(3);
        }
        if (GameObject.Find("DNB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("DNB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(7);
        }
        if (GameObject.Find("DTB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("DTB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(6);
        }
        if (GameObject.Find("DMB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("DMB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(4);
        }
    }
}
