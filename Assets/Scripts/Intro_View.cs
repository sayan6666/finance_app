using JetBrains.Annotations;
using UnityEngine;

public class Intro_View : MonoBehaviour
{
    public RectTransform BG_Obj;
    public Sprite BG;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //BG_Obj.transform.localScale = new Vector3(Screen.width,Screen.height);
       // BG.texture.Reinitialize((int)BG_Obj.localScale.x,(int)BG_Obj.localScale.y);
       // масштабирование экрана:на доработку
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
