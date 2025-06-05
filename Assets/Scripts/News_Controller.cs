using UnityEngine;

public class News_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; i++)
            if (News_Model.Blocks[i].GetComponent<Input_Handler>().Action)
            {
                News_Model.Blocks[i].GetComponent<Input_Handler>().Action = false;
                ND_Model.current = News_Model.News[i];
                Screen_Changer.Change_Screen(8);
            }
        if (GameObject.Find("Exit_News").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Exit_News").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(2);
        }
        if (GameObject.Find("NSB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("NSB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(3);
        }
        if (GameObject.Find("NMB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("NMB").GetComponent<Input_Handler>().Action = false;
            Message_Model.is_checked = true;
            Screen_Changer.Change_Screen(4);
        }
        if (GameObject.Find("NTB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("NTB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(6);
        }
    }
}
