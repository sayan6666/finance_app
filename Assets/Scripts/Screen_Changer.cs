using UnityEngine;

public class Screen_Changer : MonoBehaviour
{
    public static GameObject Camera_Object;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera_Object = GameObject.Find("Main Camera");
        //Camera_Object.GetComponent<Camera>().orthographicSize = Screen.height/*Camera_Object.GetComponent<Camera>().pixelHeight*/;
        double width_scale = Camera_Object.GetComponent<Camera>().pixelWidth / 640d;
        double height_scale = Camera_Object.GetComponent<Camera>().pixelHeight / 1136d;
        Debug.Log(width_scale);
        Debug.Log(width_scale);
        GameObject.Find("Scene").GetComponent<RectTransform>().localScale = new Vector3((float)width_scale ,(float)height_scale,1);
        Camera_Object.GetComponent<Camera>().orthographicSize =5.75f*(float)height_scale;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void Change_Screen(int screen)
    {
        Camera_Object.transform.SetLocalPositionAndRotation(new Vector3(-0.8059876f + (screen * 10), Camera_Object.transform.localPosition.y, Camera_Object.transform.localPosition.z), new Quaternion(0, 0, 0, 0));
        Main_Model.assistant.transform.SetLocalPositionAndRotation(new Vector3((screen*10)-21, Main_Model.assistant.transform.localPosition.y, Main_Model.assistant.transform.localPosition.z), new Quaternion(0, 0, 0, 0));
    }
}
