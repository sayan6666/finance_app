using UnityEngine;

public class Main_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Main_Model.ToxicGoldInc.Input_Check();
        Main_Model.GreenTechSolutions.Input_Check();
        if (GameObject.Find("Phone_Button").GetComponent<Input_Handler>().Action)
        {
            Screen_Changer.Change_Screen(3);
            GameObject.Find("Phone_Button").GetComponent<Input_Handler>().Action=false;
            //Main_Model.Screen_Active();
        }
        if (GameObject.Find("Bag_Button").GetComponent<Input_Handler>().Action)
        {
            Screen_Changer.Change_Screen(1);
            Player.fields.money_display.rectTransform.SetPositionAndRotation(new Vector3(10,Player.fields.money_display.rectTransform.position.y, Player.fields.money_display.rectTransform.position.z), new Quaternion(0,0,0,0));
            GameObject.Find("Bag_Button").GetComponent<Input_Handler>().Action = false;
            //Bag_Model.Screen_Active();
            //Main_Model.Screen_Active();    
        }
    }
}
