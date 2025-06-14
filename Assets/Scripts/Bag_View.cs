using UnityEngine;

public class Bag_View : MonoBehaviour
{
    private void Awake()
    {
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bag_Model.StocksSet();
    }

    // Update is called once per frame
    void Update()
    {
        Bag_Model.StocksSet();
        Player.fields.money_display2.SetText(Player.fields.money.ToString()+ "₽");
    }
}
