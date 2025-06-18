using UnityEngine;

public class Phone_View : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player.fields.money_display3.SetText(Player.fields.money.ToString() + "₽");
        if (Message_Controller.message>=19)
            GameObject.Find("Locks").transform.GetChild(0).GetComponent<SpriteRenderer>().sprite=null;
        if (Message_Controller.message >= 42)
            GameObject.Find("Locks").transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = null;
    }
}
