using UnityEngine;

public class Main_Controller : MonoBehaviour
{
    public static bool phone_active=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Main_Model.GreenTechSolutions.Input_Check();
        Main_Model.ToxicGoldInc.Input_Check();
        if (Input_Handler2.Input_Check())
        {
            phone_active = true;
        }
    }
}
