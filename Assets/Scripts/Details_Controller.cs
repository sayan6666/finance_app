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
    }
}
