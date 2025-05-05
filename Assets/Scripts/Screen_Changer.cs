using UnityEngine;

public class Screen_Changer : MonoBehaviour
{
    public static GameObject Camera_Object;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera_Object = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void Change_Screen(int screen)
    {
        Camera_Object.transform.SetPositionAndRotation(new Vector3(screen*10,Camera_Object.transform.position.y, Camera_Object.transform.position.z), new Quaternion(0,0,0,0));
    }
}
