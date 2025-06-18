using System.Linq;
using System.Threading;
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
        Main_Model.timer += Time.deltaTime;
        Main_Model.ToxicGoldInc.Input_Check();
        Main_Model.GreenTechSolutions.Input_Check();
        Main_Model.FashionWave.Input_Check();
        Main_Model.TechNova.Input_Check();
        Main_Model.GreenPower.Input_Check();
        Main_Model.SafeBank.Input_Check();
        if (GameObject.Find("Phone_Button").GetComponent<Input_Handler>().Action)
        {
            Screen_Changer.Change_Screen(4);
            Message_Model.is_checked = true;
            GameObject.Find("Phone_Button").GetComponent<Input_Handler>().Action=false;
            //Main_Model.Screen_Active();
        }
        if (GameObject.Find("Bag_Button").GetComponent<Input_Handler>().Action)
        {
            Screen_Changer.Change_Screen(1);
            //Player.fields.money_display.rectTransform.SetPositionAndRotation(new Vector3(10, 3.561f, Player.fields.money_display.rectTransform.position.z), new Quaternion(0,0,0,0));
            GameObject.Find("Bag_Button").GetComponent<Input_Handler>().Action = false;
            //Bag_Model.Screen_Active();
            //Main_Model.Screen_Active();    
        }
        if (GameObject.Find("Wait_Button").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Wait_Button").GetComponent<Input_Handler>().Action = false;
            Wait_Model.StatsUpdate(new int[6] { Random.Range(News_Model.News[2].instanced ? 20000 : 4000, News_Model.News[2].instanced ? 30000 : 9900), Random.Range(4500, 9600), Random.Range(100,800), Random.Range(2000,5000), Random.Range(4500,7000), Random.Range(7000,10000) });
            Player.fields.day++;
            /* Main_Model.GreenTechSolutions.fields.price = 100;
             Main_Model.FashionWave.fields.price = 80;
             Main_Model.ToxicGoldInc.fields.price = 1;*/
            if (!Task_Model.difchoice.done)
            {
                if (!Main_Model.TechNova.LastWeekAdvice() && !Main_Model.GreenPower.LastWeekAdvice() && !Main_Model.SafeBank.LastWeekAdvice())
                    Main_Model.verdict = 0;
                else
                { Task_Model.difchoice.done = true; }
            }
            if (!Task_Model.firstsstock.done)
            {
                if (!Main_Model.GreenTechSolutions.LastWeekAdvice() && !Main_Model.FashionWave.LastWeekAdvice() && !Main_Model.ToxicGoldInc.LastWeekAdvice())
                    Main_Model.verdict = 0;
                else
                { Task_Model.firstsstock.done = true; }
            }
            
            Screen_Changer.Change_Screen(-1);
            Main_Model.timer = 0;
            DB_Handler.Update_Player(Player.fields);
            /*for (int i = 0; i < Main_Model.Stock_List.stocks.Length; i++)
                DB_Handler.Update_Stock(Main_Model.Stock_List.stocks[i]);*/
            DB_Handler.Update_Stock(Main_Model.GreenTechSolutions.fields/*Stock_List.stocks[0]*/);
            DB_Handler.Update_Stock(Main_Model.FashionWave.fields);
            DB_Handler.Update_Stock(Main_Model.ToxicGoldInc.fields);
            DB_Handler.Update_Stock(Main_Model.TechNova.fields);
            DB_Handler.Update_Stock(Main_Model.GreenPower.fields);
            DB_Handler.Update_Stock(Main_Model.SafeBank.fields);
        }
        if (GameObject.Find("News_Button").GetComponent<Input_Handler>().Action==true)
        {
            GameObject.Find("News_Button").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(7);
        }
        if (GameObject.Find("TBM").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("TBM").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(6);
        }
        if (GameObject.Find("SBM").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("SBM").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(3);
        }
        if (Main_Model.timer >= 2f && GameObject.Find("Main Camera").transform.position.x < -5)
            Screen_Changer.Change_Screen(2);

        if (GameObject.Find("next_stock").GetComponent<Input_Handler>().Action && Message_Controller.message>=40)
        {
            GameObject.Find("next_stock").GetComponent<Input_Handler>().Action = false;
            var sy1 = GameObject.Find("Stock4").transform.localPosition.y;
            var sy2 = GameObject.Find("Stock5").transform.localPosition.y;
            var sy3 = GameObject.Find("Stock6").transform.localPosition.y;
            GameObject.Find("Stock4").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, GameObject.Find("Stock1").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock5").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, GameObject.Find("Stock2").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock6").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, GameObject.Find("Stock3").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock1").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, sy1, 0),new Quaternion(0,0,0,0));
            GameObject.Find("Stock2").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, sy2, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock3").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, sy3, 0), new Quaternion(0, 0, 0, 0));
        }
        if (GameObject.Find("Prev_stock").GetComponent<Input_Handler>().Action && Message_Controller.message >= 40)
        {
            GameObject.Find("Prev_stock").GetComponent<Input_Handler>().Action = false;
            var sy1 = GameObject.Find("Stock4").transform.localPosition.y;
            var sy2 = GameObject.Find("Stock5").transform.localPosition.y;
            var sy3 = GameObject.Find("Stock6").transform.localPosition.y;
            GameObject.Find("Stock4").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, GameObject.Find("Stock1").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock5").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, GameObject.Find("Stock2").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock6").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, GameObject.Find("Stock3").transform.localPosition.y, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock1").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, sy1, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock2").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, sy2, 0), new Quaternion(0, 0, 0, 0));
            GameObject.Find("Stock3").transform.SetLocalPositionAndRotation(new Vector3(-0.0094f, sy3, 0), new Quaternion(0, 0, 0, 0)); 
        }
    }
}
