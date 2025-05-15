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
            /*
            Main_Model.Screen_Active();
            Bag_Model.Screen_Active();*/
            Screen_Changer.Change_Screen(2);
            //Player.fields.money_display.rectTransform.SetPositionAndRotation(new Vector3(18.183f, 3.78f, Player.fields.money_display.rectTransform.position.z), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Exit_Bag_Button").GetComponent<Input_Handler>().Action = false;
        }
    }
}
