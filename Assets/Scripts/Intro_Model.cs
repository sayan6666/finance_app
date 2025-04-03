using UnityEngine;

public class Intro_Model : MonoBehaviour
{
    public GameObject Intro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Intro_Controller.Intro_Ended == true)
            Intro.SetActive(false);
    }
}
