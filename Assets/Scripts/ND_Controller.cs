using UnityEngine;

public class ND_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Exit_Details").GetComponent<Input_Handler>().Action)
        {
            Screen_Changer.Change_Screen(7);
            GameObject.Find("Exit_Details").GetComponent<Input_Handler>().Action = false;
        }
        if (GameObject.Find("Exit_ND").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Exit_ND").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(2);
        }
        if (GameObject.Find("NDSB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("NDSB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(3);
        }
        if (GameObject.Find("NDMB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("NDMB").GetComponent<Input_Handler>().Action = false;
            Message_Model.is_checked = true;
            Screen_Changer.Change_Screen(4);
        }
        if (GameObject.Find("NDTB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("NDTB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(6);
        }
    }
}
