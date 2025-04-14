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
        Main_Model.GreenTechSolutions.Input_Check();
        Main_Model.ToxicGoldInc.Input_Check();
    }
}
