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
            Wait_Model.StatsUpdate(new int[3] { Random.Range(News_Model.News[2].instanced ? 20000 : 4000, News_Model.News[2].instanced ? 20000 : 9900), Random.Range(4500, 9600), Random.Range(100,800) });
            Player.fields.day++;
            /* Main_Model.GreenTechSolutions.fields.price = 100;
             Main_Model.FashionWave.fields.price = 80;
             Main_Model.ToxicGoldInc.fields.price = 1;*/
            if (Task_Model.marked[0] == 0)
            {
                if (!Main_Model.GreenTechSolutions.LastWeekAdvice() && !Main_Model.FashionWave.LastWeekAdvice() && !Main_Model.ToxicGoldInc.LastWeekAdvice())
                    Main_Model.verdict = 0;
                else
                { Task_Model.marked[0] = 1; }
            }
            Screen_Changer.Change_Screen(-1);
            Main_Model.timer = 0;
            DB_Handler.Update_Player(Player.fields);
            /*for (int i = 0; i < Main_Model.Stock_List.stocks.Length; i++)
                DB_Handler.Update_Stock(Main_Model.Stock_List.stocks[i]);*/
            DB_Handler.Update_Stock(Main_Model.GreenTechSolutions.fields/*Stock_List.stocks[0]*/);
            DB_Handler.Update_Stock(Main_Model.FashionWave.fields);
            DB_Handler.Update_Stock(Main_Model.ToxicGoldInc.fields);
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
    }
}
