using UnityEngine;

public class Message_Controller : MonoBehaviour
{
    public static bool phone_inactive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input_Handler2.Input_Check())
        {
            phone_inactive = true;
            //Debug.Log("overlap");
        }
    }
}
