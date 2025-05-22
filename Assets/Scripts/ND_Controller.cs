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
    }
}
