using UnityEngine;

public class Bag_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (GameObject.Find("Exit_Bag_Button").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Exit_Bag_Button").GetComponent<Input_Handler>().Action = false;
            Main_Model.Screen_Active();
            Bag_Model.Screen_Active();
        }
    }
}
