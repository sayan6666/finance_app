using UnityEngine;

public class Status_Model : MonoBehaviour
{
    public Sprite button;
    public Sprite status1;
    public Sprite status2;
    public Sprite status3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Player.fields.status==2 && GameObject.Find("Status_BG").GetComponent<SpriteRenderer>().sprite==status2) || (Player.fields.status == 3 && GameObject.Find("Status_BG").GetComponent<SpriteRenderer>().sprite == status3))
            GameObject.Find("Button_Cover").GetComponent<SpriteRenderer>().sprite=button;
        else
            GameObject.Find("Button_Cover").GetComponent<SpriteRenderer>().sprite = null;

        if (GameObject.Find("Exit_Status").GetComponent<Input_Handler>().Action)
        {
            GameObject.Find("Exit_Status").GetComponent<Input_Handler>().Action = false;
            Screen_Changer.Change_Screen(3);
        }
        if (GameObject.Find("Buy_Status").GetComponent<Input_Handler>().Action && Player.fields.money>=1000)
        {

            Debug.Log("+++");
            if (GameObject.Find("Status_BG").GetComponent<SpriteRenderer>().sprite == status2 && Player.fields.status ==1)
            {
                Debug.Log("+");
                Player.fields.status = 2;
                Player.fields.money -= 1000;
            }
            if (GameObject.Find("Status_BG").GetComponent<SpriteRenderer>().sprite == status3 && Player.fields.status ==2)
            {
                Debug.Log("++");
                Player.fields.status = 3;
                Player.fields.money -= 1000;
            }
            GameObject.Find("Buy_Status").GetComponent<Input_Handler>().Action = false;
        }
    }
}
