using UnityEngine;
using UnityEngine.Windows;

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

       if (GameObject.Find("BCB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("BCB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(2);
        }
        if (GameObject.Find("BSB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("BSB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(3);
        }
        if (GameObject.Find("BNB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("BNB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(7);
        }
        if (GameObject.Find("BTB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("BTB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(6);
        }
        if (GameObject.Find("BMB").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("BMB").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(4);
        }
        if (GameObject.Find("next_stock_bag").GetComponent<Input_Handler>().Action && Message_Controller.message >= 40)
        {
            GameObject.Find("next_stock_bag").GetComponent<Input_Handler>().Action = false;
            var sy1 = GameObject.Find("Bag_Stock4").transform.localPosition.y;
            var sy2 = GameObject.Find("Bag_Stock5").transform.localPosition.y;
            var sy3 = GameObject.Find("Bag_Stock6").transform.localPosition.y;
            GameObject.Find("Bag_Stock4").transform.SetLocalPositionAndRotation(new Vector3(0.35f, GameObject.Find("Bag_Stock1").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock5").transform.SetLocalPositionAndRotation(new Vector3(0.35f, GameObject.Find("Bag_Stock2").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock6").transform.SetLocalPositionAndRotation(new Vector3(0.35f, GameObject.Find("Bag_Stock3").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock1").transform.SetLocalPositionAndRotation(new Vector3(0.35f, sy1, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock2").transform.SetLocalPositionAndRotation(new Vector3(0.35f, sy2, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock3").transform.SetLocalPositionAndRotation(new Vector3(0.35f, sy3, 0), new Quaternion(0, 0, 0, 0));
        }
        if (GameObject.Find("Prev_stock_bag").GetComponent<Input_Handler>().Action && Message_Controller.message >= 40)
        {
            GameObject.Find("Prev_stock_bag").GetComponent<Input_Handler>().Action = false;
            var sy1 = GameObject.Find("Stock4").transform.localPosition.y;
            var sy2 = GameObject.Find("Stock5").transform.localPosition.y;
            var sy3 = GameObject.Find("Stock6").transform.localPosition.y;
            GameObject.Find("Bag_Stock4").transform.SetLocalPositionAndRotation(new Vector3(0.35f, GameObject.Find("Bag_Stock1").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock5").transform.SetLocalPositionAndRotation(new Vector3(0.35f, GameObject.Find("Bag_Stock2").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock6").transform.SetLocalPositionAndRotation(new Vector3(0.35f, GameObject.Find("Bag_Stock3").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock1").transform.SetLocalPositionAndRotation(new Vector3(0.35f, sy1, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock2").transform.SetLocalPositionAndRotation(new Vector3(0.35f, sy2, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Bag_Stock3").transform.SetLocalPositionAndRotation(new Vector3(0.35f, sy3, 0), new Quaternion(0, 0, 0, 0));
        }
    }
}
