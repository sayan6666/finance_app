using UnityEngine;

public class Intro_Controller : MonoBehaviour
{
    public static bool Intro_Ended { get; set;  } = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Start_Handle.Action)
            Intro_Ended = true;
    }
}
