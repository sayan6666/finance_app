using TMPro;
using UnityEngine;

public class Task_Model : MonoBehaviour
{
    public static Input_Handler Exit_Action;
    public static int marked;
    public Sprite Done1;
    public Sprite Done2;
    public static Task firstsstock;
    public static Task knowledge;
    public static Task difchoice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Exit_Action = GameObject.Find("Exit_Button").GetComponent<Input_Handler>();
        marked = 0;
        firstsstock = new Task("<b>Цель:</b> \r\n На основе данных (P/E, дивиденды, рост прибыли) выбрать акцию для покупки.\r\n<b>Варианты:</b>\r\n GreenTech Solutions (P/E 15, дивиденды 4%, рост прибыли +25%)\r\n FashionWave (P/E 30, дивиденды 2%, рост прибыли +5%)\r\n ToxicGold Inc. (P/E —, дивиденды 0%, рост прибыли -50%)", "Выбор первой акции", false,false,100000);
        knowledge = new Task("", "Срез знаний", false,false,150000);
        difchoice = new Task("", "Трудный выбор", false, false, 150000);
        GameObject.Find("Task1").transform.GetChild(0).GetComponent<TextMeshPro>().SetText(firstsstock.title);
        GameObject.Find("Task2").transform.GetChild(0).GetComponent<TextMeshPro>().SetText(knowledge.title);
        GameObject.Find("Task3").transform.GetChild(0).GetComponent<TextMeshPro>().SetText(difchoice.title);
    }

    // Update is called once per frame
    void Update()
    {
        if (Message_Controller.message >= 17)
            GameObject.Find("Task1").transform.SetLocalPositionAndRotation(new Vector3(0, 3.5f, 0), new Quaternion(0, 0, 0, 0));
        if (firstsstock.done==true)
            GameObject.Find("Task1").GetComponent<SpriteRenderer>().sprite = Done1;
        if (Message_Controller.message >= 19)
            GameObject.Find("Task2").transform.SetLocalPositionAndRotation(new Vector3(0, 1.5f, 0), new Quaternion(0, 0, 0, 0));
        if (knowledge.done == true)
            GameObject.Find("Task2").GetComponent<SpriteRenderer>().sprite = Done1;
        if (Message_Controller.message >= 40)
            GameObject.Find("Task3").transform.SetLocalPositionAndRotation(new Vector3(0, -0.5f, 0), new Quaternion(0, 0, 0, 0));
        if (difchoice.done == true)
            GameObject.Find("Task3").GetComponent<SpriteRenderer>().sprite = Done1;

        if (marked == 1)
        {
            GameObject.Find("Task_Text").GetComponent<TextMeshPro>().SetText(firstsstock.text);
            GameObject.Find("Task_Name").GetComponent<TextMeshPro>().SetText(firstsstock.title);
        }
        if (marked == 2)
        {
            GameObject.Find("Task_Text").GetComponent<TextMeshPro>().SetText(knowledge.text);
            GameObject.Find("Task_Name").GetComponent<TextMeshPro>().SetText(knowledge.title);
        }
        if (marked == 3)
        {
            GameObject.Find("Task_Text").GetComponent<TextMeshPro>().SetText(difchoice.text);
            GameObject.Find("Task_Name").GetComponent<TextMeshPro>().SetText(difchoice.title);
        }

        if (GameObject.Find("Claim_Button").GetComponent<Input_Handler>().Action)
        {
            switch (marked)
            {
                case 1:
                    {
                        if (!firstsstock.claimed && firstsstock.done)
                        {
                            firstsstock.claimed = true;
                            Player.fields.money += firstsstock.reward;
                        }
                        break;
                    }
                case 2:
                    {
                        if (!knowledge.claimed && knowledge.done)
                        {
                            knowledge.claimed = true;
                            Player.fields.money += knowledge.reward;
                        }
                        break;
                    }
                case 3:
                    {
                        if (!difchoice.claimed && difchoice.done)
                        {difchoice.claimed = true;

                            Player.fields.money += difchoice.reward;
                        }
                        break;
                    }
            }
        }
        if ((marked==1 && firstsstock.claimed) || (marked == 2 && knowledge.claimed) || (marked == 3 && difchoice.claimed))
        {
            GameObject.Find("Claim_Button").GetComponent<SpriteRenderer>().sprite = Done2;
        }
        else
            GameObject.Find("Claim_Button").GetComponent<SpriteRenderer>().sprite = null;
    }
}
